using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class EditRecipeParams
  {
    public IEnumerable<Ingredient> Ingredients { get; set; }
    public IAddIngredient IngredientAdder { get; set; }
    public IEnumerable<TemplateRecipe> TemplateRecipes { get; set; }

    public IEnumerable<BaseIngredient> BaseIngredients
    {
      get
      {
        foreach (var i in Ingredients)
          yield return i;

        foreach (var t in TemplateRecipes)
          yield return t;
      }
    }

    public Dictionary<string, BaseIngredient> CreateDictionary() => BaseIngredients.ToDictionary(i => i.Id);
  }
}
