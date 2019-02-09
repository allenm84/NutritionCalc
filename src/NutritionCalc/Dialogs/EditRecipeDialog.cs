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
      if (!ingredientTable.ContainsKey(item?.ItemId ?? string.Empty))
      {
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

    private void btnUseBaseRecipe_Click(object sender, EventArgs e)
    {
      if (gridViewItems.GetFocusedRow() is RecipeItem item)
      {
        DoFindTemplateRecipe(item);
      }
    }

    private void btnFindIngredients_Click(object sender, EventArgs e)
    {
      DoFindIngredients();
    }

    private void btnCalculateNutrition_Click(object sender, EventArgs e)
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
            // take the desired amount and convert 
            var totalUnit = unit.Factor * item.Quantity;

            // lets say the serving size is 5 grams, and we have a total of 10 grams.
            // To get the factor, we take the total grams and divide by the serving size
            var servingSizeUnit = servingSize.Unit.Factor * servingSize.Amount;
            var factor = totalUnit / servingSizeUnit;

            // with this factor, we need to scale the nutrition info
            nutrition += (ingredient.Nutrition * factor);
          }
          else
          {
            var unitType = item.UnitTypeName;
            errorMessage = $"You entered in a {unitType}, but {ingredient.Name} does not have a {unitType} defined";
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
  }
}