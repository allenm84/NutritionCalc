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
  }
}
