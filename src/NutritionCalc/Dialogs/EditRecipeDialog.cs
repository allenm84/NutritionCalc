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
      var items = recipeItemBindingSource.OfType<RecipeItem>();
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
      btnDeleteRecipe.Text = IsRecipe
        ? "Delete Recipe" 
        : "Delete Base Recipe";
    }

    public void WriteTo(TemplateRecipe recipe)
    {
      recipe.Name = txtRecipeName.Text;
      recipe.Ingredients = recipeItemBindingSource.OfType<RecipeItem>().ToList();
      nutritionInfoEdit.WriteTo(recipe);
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

    private void btnUseBaseRecipe_Click(object sender, EventArgs e)
    {
      if (gridViewItems.GetFocusedRow() is RecipeItem item)
      {
        DoFindTemplateRecipe(item);
      }
    }

    private void btnFindIngredients_Click(object sender, EventArgs e)
    {
      if (recipeItemBindingSource.Count > 0)
      {
        DoFindIngredients();
      }
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

          // go through the supported unit types and get the nutrition information
          if (unit is WeightUnit weight)
          {
            var servingSize = ingredient.ServingSizeWeight;
            if (servingSize.Unit != null)
            {
              // take the desired amount and convert to grams
              var totalGrams = weight.AsGrams * item.Quantity;

              // lets say the serving size is 5 grams, and we have a total of 10 grams.
              // To get the factor, we take the total grams and divide by the serving size
              var servingSizeGrams = servingSize.Unit.AsGrams * servingSize.Amount;
              var factor = totalGrams / servingSizeGrams;

              // with this factor, we need to scale the nutrition info
              nutrition += (ingredient.Nutrition * factor);
            }
            else
            {
              errorMessage = $"You entered in a Weight, but {ingredient.Name} does not have a Weight unit defined";
              succeeded = false;
              break;
            }
          }
        }
        else
        {
          errorMessage = $"{item.Text} could not be found, so nutrition info cannot be calculated.";
          succeeded = false;
        }
      }

      if (!succeeded)
      {
        ShowError(errorMessage);
      }
    }

    private void btnDeleteRecipe_Click(object sender, EventArgs e)
    {
      var type = IsRecipe ? "recipe" : "base recipe";
      if (Confirm($"Are you sure you want to delete this {type}? "))
      {
        InternalCustomDialogResult = CustomDialogResult.Delete;
        Close();
      }
    }
  }
}