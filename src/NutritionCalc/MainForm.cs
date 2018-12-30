using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using Newtonsoft.Json;

namespace NutritionCalc
{
  public partial class MainForm : BaseForm, IAddIngredient
  {
    private readonly string mFilepath;

    public MainForm()
    {
      InitializeComponent();
      mFilepath = "data.json";
      LoadData();
    }

    private EditRecipeParams EditRecipeInfo => new EditRecipeParams
    {
      IngredientAdder = this,
      Ingredients = grpIngredients.OfType<Ingredient>(),
      TemplateRecipes = templateRecipeBindingSource.OfType<TemplateRecipe>(),
    };

    private void LoadData()
    {
      // read the data or create a new profile
      var data = File.Exists(mFilepath)
        ? JsonConvert.DeserializeObject<NutritionCalcData>(File.ReadAllText(mFilepath))
        : new NutritionCalcData();

      // populate the ingredients
      grpIngredients.Populate(Enums<IngredientCategory>.Values, data.Ingredients, i => i.Category);

      // populate the template recipes
      foreach (var r in data.TemplateRecipes)
      {
        templateRecipeBindingSource.Add(r);
      }

      // populate the recipes
      foreach (var r in data.Recipes)
      {
        recipeBindingSource.Add(r);
      }
    }

    private bool DoEditIngredient(Ingredient ingredient, bool isAdding)
    {
      var wasAdded = false;

      using (var dlg = new EditIngredientDialog())
      {
        dlg.ReadFrom(!isAdding, ingredient, !isAdding);

        var result = dlg.ShowDialogCustom(this);
        if (result == CustomDialogResult.OK)
        {
          dlg.WriteTo(ingredient);
          if (isAdding)
          {
            grpIngredients.AddItem(ingredient, i => i.Category);
            wasAdded = true;
          }
          else
          {
            grpIngredients.UpdateItem(ingredient, i => i.Category);
          }
        }
        else if (result == CustomDialogResult.Delete)
        {
          grpIngredients.RemoveItem(ingredient, i => i.Category);
        }
      }

      return wasAdded;
    }

    private void DoEditTemplateRecipe(TemplateRecipe recipe, bool isAdding)
    {
      using (var dlg = new EditRecipeDialog(EditRecipeInfo))
      {
        dlg.ReadFrom(recipe);
        var result = dlg.ShowDialogCustom(this);
        if (result == CustomDialogResult.OK)
        {
          dlg.WriteTo(recipe);
          if (isAdding)
          {
            templateRecipeBindingSource.Add(recipe);
          }
          else
          {
            var index = templateRecipeBindingSource.IndexOf(recipe);
            templateRecipeBindingSource.ResetItem(index);
          }
        }
        else if (result == CustomDialogResult.Delete)
        {
          templateRecipeBindingSource.Remove(recipe);
        }
      }
    }

    private void DoEditRecipe(Recipe recipe, bool isAdding)
    {
      using (var dlg = new EditRecipeDialog(EditRecipeInfo))
      {
        dlg.ReadFrom(recipe);
        var result = dlg.ShowDialogCustom(this);
        if (result == CustomDialogResult.OK)
        {
          dlg.WriteTo(recipe);
          if (isAdding)
          {
            recipeBindingSource.Add(recipe);
          }
          else
          {
            var index = recipeBindingSource.IndexOf(recipe);
            recipeBindingSource.ResetItem(index);
          }
        }
        else if (result == CustomDialogResult.Delete)
        {
          recipeBindingSource.Remove(recipe);
        }
      }
    }

    bool IAddIngredient.AddIngredient(string name, out Ingredient ingredient)
    {
      ingredient = new Ingredient { Name = name };
      return DoEditIngredient(ingredient, true);
    }

    private void tbbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      var data = new NutritionCalcData();
      data.Ingredients = grpIngredients.OfType<Ingredient>().ToList();
      data.Recipes = recipeBindingSource.OfType<Recipe>().ToList();
      data.TemplateRecipes = templateRecipeBindingSource.OfType<TemplateRecipe>().ToList();
      var json = JsonConvert.SerializeObject(data);
      File.WriteAllText(mFilepath, json);
    }

    private void grpIngredients_ItemClicked(object sender, GroupedItemViewEventArgs e)
    {
      if (e.Item is Ingredient ingredient)
      {
        DoEditIngredient(ingredient, false);
      }
    }

    private void btnAddIngredient_Click(object sender, EventArgs e)
    {
      DoEditIngredient(new Ingredient { Name = string.Empty }, true);
    }

    private void lstBaseRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (lstBaseRecipes.SelectedItem is TemplateRecipe recipe)
      {
        DoEditTemplateRecipe(recipe, false);
      }
    }

    private void btnAddBaseRecipe_Click(object sender, EventArgs e)
    {
      DoEditTemplateRecipe(new TemplateRecipe { Name = string.Empty }, true);
    }

    private void lstRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (lstRecipes.SelectedItem is Recipe recipe)
      {
        DoEditRecipe(recipe, false);
      }
    }

    private void btnAddRecipe_Click(object sender, EventArgs e)
    {
      DoEditRecipe(new Recipe { Name = string.Empty }, true);
    }
  }
}
