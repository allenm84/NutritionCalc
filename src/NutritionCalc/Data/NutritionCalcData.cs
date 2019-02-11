using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class NutritionCalcData
  {
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public List<TemplateRecipe> TemplateRecipes { get; set; } = new List<TemplateRecipe>();
    public List<Recipe> Recipes { get; set; } = new List<Recipe>();

    public IEnumerable<BaseIngredient> All
    {
      get
      {
        foreach (var i in Ingredients) yield return i;
        foreach (var t in TemplateRecipes) yield return t;
        foreach (var r in Recipes) yield return r;
      }
    }
  }
}
