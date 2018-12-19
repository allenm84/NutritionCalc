using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class TemplateRecipe : BaseIngredient
  {
    public List<RecipeItem> Ingredients { get; set; } = new List<RecipeItem>();
  }
}
