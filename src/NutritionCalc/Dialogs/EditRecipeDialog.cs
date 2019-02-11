using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NutritionCalc.Properties;
using DevExpress.Utils;

namespace NutritionCalc
{
  public partial class EditRecipeDialog : BaseForm
  {
    private readonly EditRecipeParams mEditRecipeParams;

    public EditRecipeDialog(EditRecipeParams editRecipeParams)
    {
      mEditRecipeParams = editRecipeParams;
      InitializeComponent();

      recipeItemBindingSource.RaiseListChangedEvents = true;
      recipeItemBindingSource.ListChanged += recipeItems_ListChanged;
    }

    private bool IsRecipe { get; set; }

    private async void DoFindIngredients()
    {
      var ingredientTable = mEditRecipeParams.CreateDictionary();
      var items = recipeItemBindingSource
        .OfType<RecipeItem>()
        .Where(i => !ingredientTable.ContainsKey(i.ItemId ?? string.Empty))
        .ToArray();

      if (!items.Any())
      {
        if (recipeItemBindingSource.Count > 0)
        {
          Inform($"All of the items in the recipe have been found. You can reset the items by clicking the {btnReset.Text} button.");
        }
        return;
      }

      var task = Task.Run(() => RecipeItemParser.Run(items, mEditRecipeParams.Ingredients).ToArray());
      var delay = Task.Delay(TimeSpan.FromSeconds(1));

      var completed = await Task.WhenAny(delay, task);
      if (completed == delay)
      {
        splashScreenManager1.ShowWaitForm();
        await task;
        splashScreenManager1.CloseWaitForm();
      }

      var results = task.Result;
      using (var dlg = new RecipeItemParseResultsWizard(mEditRecipeParams.IngredientAdder, results))
      {
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          dlg.Commit();
          gridViewItems.RefreshData();
        }
      }
    }

    private async void DoFindTemplateRecipe(RecipeItem item)
    {
      var ingredientTable = mEditRecipeParams.CreateDictionary();
      if (ingredientTable.ContainsKey(item?.ItemId ?? string.Empty))
      {
        Inform($"{item.Text} has already been found. You can reset it by clicking the {btnReset.Text} button.");
        return;
      }

      var task = Task.Run(() => RecipeItemParser.Run(item, mEditRecipeParams.TemplateRecipes));
      var delay = Task.Delay(TimeSpan.FromSeconds(1));

      var completed = await Task.WhenAny(delay, task);
      if (completed == delay)
      {
        splashScreenManager1.ShowWaitForm();
        await task;
        splashScreenManager1.CloseWaitForm();
      }

      var result = task.Result;
      if (result.Success)
      {
        using (var dlg = new RecipeItemParseResultsWizard(mEditRecipeParams.IngredientAdder, result))
        {
          if (dlg.ShowDialog(this) == DialogResult.OK)
          {
            dlg.Commit();
            gridViewItems.RefreshData();
          }
        }
      }
      else
      {
        var input = result.SearchText ?? item.Text;
        Inform($"Unable to find '{input}' in the base recipes", "Failed to Find");
      }
    }

    private void DoCalculateNutrition()
    {
      var nutrition = new NutritionInfo();

      var succeeded = true;
      var errorMessage = string.Empty;

      var ingredientTable = mEditRecipeParams.CreateDictionary();
      foreach (var item in recipeItemBindingSource.OfType<RecipeItem>())
      {
        if (ingredientTable.TryGetValue(item.ItemId ?? string.Empty, out BaseIngredient ingredient))
        {
          // get the unit that the user entered into the recipe
          var unit = Units.FromSelection((item.UnitId, item.UnitTypeName));
          if (TryGetServingSize(ingredient, unit, out IServingSize servingSize))
          {
            try
            {
              // take the desired amount and convert 
              var totalUnit = unit.Factor * item.Quantity;

              // lets say the serving size is 5 grams, and we have a total of 10 grams.
              // To get the factor, we take the total grams and divide by the serving size
              var servingSizeUnit = servingSize.Unit.Factor * servingSize.Amount;
              var factor = totalUnit / servingSizeUnit;

              // with this factor, we need to scale the nutrition info
              nutrition += (ingredient.Nutrition * factor);
            }
            catch
            {
              var sb = new StringBuilder();
              sb.AppendLine("There was an error while calculating the nutrition. Make sure the following information is valid:");
              sb.AppendLine();
              sb.AppendLine($"Name: {ingredient.Name}");
              sb.AppendLine($"Serving Size: {servingSize.Amount} {servingSize.Unit.Display}");
              sb.AppendLine($"Amount: {item.Quantity}");
              sb.AppendLine();
              sb.AppendLine("The serving size and amount cannot be 0. You may need to edit the ingredient.");
              errorMessage = $"{sb}";
              succeeded = false;
              break;
            }
          }
          else
          {
            var sb = new StringBuilder();
            sb.AppendLine($"You entered in a {unit.Display}, but {ingredient.Name} does not have a {unit.Display} defined");

            var units = new List<string>();
            foreach (var serving in ingredient.Servings)
            {
              if (serving.Unit != null)
              {
                units.Add(serving.Unit.Display);
              }
            }

            sb.AppendLine();
            if (units.Count > 0)
            {
              sb.AppendLine($"{ingredient.Name} has these units defined:");
              foreach (var value in units)
              {
                sb.AppendLine($"  * {value}");
              }
            }
            else
            {
              sb.AppendLine($"Actually, {ingredient.Name} has no units defined.");
            }

            errorMessage = $"{sb}";
            succeeded = false;
            break;
          }
        }
        else
        {
          errorMessage = $"{item.Text} could not be found; nutrition info cannot be calculated.";
          succeeded = false;
          break;
        }
      }

      if (!succeeded)
      {
        ShowError(errorMessage);
      }
      else
      {
        nutritionInfoEdit.ReadNutrition(nutrition);
      }
    }

    public void ReadFrom(TemplateRecipe recipe)
    {
      txtRecipeName.Text = recipe.Name;
      foreach (var item in recipe.Ingredients.Select(i => i.Clone()))
      {
        recipeItemBindingSource.Add(item);
      }

      IsRecipe = (recipe is Recipe);
      nutritionInfoEdit.ReadFrom(recipe);
      lcUseBaseRecipe.ContentVisible = IsRecipe;
    }

    public void WriteTo(TemplateRecipe recipe)
    {
      recipe.Name = txtRecipeName.Text;
      recipe.Ingredients = recipeItemBindingSource.OfType<RecipeItem>().ToList();
      nutritionInfoEdit.WriteTo(recipe);
    }

    private static bool TryGetServingSize(BaseIngredient ingredient, Unit unit, out IServingSize size)
    {
      size = ingredient.Servings.SingleOrDefault(s => s.Unit?.CanConvertTo(unit) ?? false);
      return (size != null);
    }

    private void MoveNextRow()
    {
      int rowHandle = gridViewItems.FocusedRowHandle;
      if (gridViewItems.IsNewItemRow(rowHandle) && gridViewItems.ActiveEditor == null)
      {
        return;
      }

      gridViewItems.CloseEditor();
      gridViewItems.MoveNext();

      if (rowHandle == gridViewItems.FocusedRowHandle)
      {
        // the row did not change
        gridViewItems.AddNewRow();
      }
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
      if (keyData == Keys.Enter && gridItems.IsFocused)
      {
        MoveNextRow();
        return true;
      }
      else
      {
        return base.ProcessDialogKey(keyData);
      }
    }

    private void recipeItems_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemChanged &&
        recipeItemBindingSource.At(e.NewIndex) is RecipeItem item &&
        string.IsNullOrWhiteSpace(item.Text))
      {
        var row = gridViewItems.GetRowHandle(e.NewIndex);
        gridViewItems.DeleteRow(row);
        gridViewItems.RefreshData();
      }
    }

    private void toolTipController1_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
    {
      if (e.Info == null && e.SelectedControl == gridItems)
      {
        var info = gridViewItems.CalcHitInfo(e.ControlMousePosition);
        if (info.InRowCell && gridViewItems.GetRow(info.RowHandle) is RecipeItem item && info.Column == colState)
        {
          var ingredientTable = mEditRecipeParams.CreateDictionary();
          if (ingredientTable.TryGetValue(item.ItemId ?? string.Empty, out var ingredient))
          {
            var key = $"{info.RowHandle}:{info.Column}";
            var text = $"Linked to {ingredient.Name}";
            e.Info = new ToolTipControlInfo(key, text);
          }
        }
      }
    }

    private void gridViewItems_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (e.Column == colBullet)
      {
        e.Value = "\u2022";
      }
      else if (e.Column == colState && e.Row is RecipeItem item)
      {
        var ingredientTable = mEditRecipeParams.CreateDictionary();
        e.Value = ingredientTable.ContainsKey(item.ItemId ?? string.Empty)
          ? Resources.tick_small 
          : null;
      }
    }

    private void gridViewItems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete &&
        gridViewItems.GetFocusedRow() is RecipeItem item &&
        Confirm($"Are you sure you want to delete {item.Text}?"))
      {
        recipeItemBindingSource.Remove(item);
      }
      else if (e.KeyCode == Keys.Enter)
      {
        MoveNextRow();
      }
    }

    private void gridViewItems_ShowingEditor(object sender, CancelEventArgs e)
    {
      if (gridViewItems.GetFocusedRow() is RecipeItem item)
      {
        var ingredientTable = mEditRecipeParams.CreateDictionary();
        e.Cancel = ingredientTable.ContainsKey(item.ItemId ?? string.Empty);
      }
    }

    private void btnUseBaseRecipe_Click(object sender, EventArgs e)
    {
      if (gridViewItems.GetFocusedRow() is RecipeItem item)
      {
        DoFindTemplateRecipe(item);
      }
      else
      {
        Inform($"Make sure you have an item selected. The {btnUseBaseRecipe.Text} button will only work for the currently selected item.");
      }
    }

    private void btnFindIngredients_Click(object sender, EventArgs e)
    {
      DoFindIngredients();
    }

    private void btnCalculateNutrition_Click(object sender, EventArgs e)
    {
      DoCalculateNutrition();
    }

    private void btnDeleteRecipe_Click(object sender, EventArgs e)
    {
      var type = IsRecipe ? "recipe" : "base recipe";
      if (Confirm($"Are you sure you want to delete this {type}?"))
      {
        InternalCustomDialogResult = CustomDialogResult.Delete;
        Close();
      }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      var ingredientTable = mEditRecipeParams.CreateDictionary();
      var items = recipeItemBindingSource
        .OfType<RecipeItem>()
        .Where(i => ingredientTable.ContainsKey(i.ItemId ?? string.Empty))
        .ToArray();

      if (!items.Any())
      {
        Inform("There is nothing to reset; none of the items have been found.");
        return;
      }

      using (var dlg = new ResetRecipeItemsDialog(items))
      {
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var toReset = dlg.CheckedItems.ToArray();
          if (toReset.Any())
          {
            foreach (var item in toReset)
            {
              item.ItemId = string.Empty;
            }

            gridViewItems.RefreshData();
            Inform("Selected items have been reset");
          }
        }
      }
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
      using (var dlg = new NumberEntryDialog())
      {
        dlg.Text = "Multiply";
        dlg.Prompt = "Multiply By:";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var value = nutritionInfoEdit.Nutrition;
          value *= dlg.Value;
          nutritionInfoEdit.ReadNutrition(value);
        }
      }
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
      using (var dlg = new NumberEntryDialog())
      {
        dlg.Text = "Divide";
        dlg.Prompt = "Divide By:";
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var value = nutritionInfoEdit.Nutrition;
          value /= dlg.Value;
          nutritionInfoEdit.ReadNutrition(value);
        }
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      var errorText = nutritionInfoEdit.GetErrorText();
      if (!string.IsNullOrWhiteSpace(errorText))
      {
        ShowError(errorText);
        mCancelClose = true;
      }
    }
  }
}