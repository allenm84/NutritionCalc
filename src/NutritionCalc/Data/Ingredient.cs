using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class Ingredient : BaseIngredient
  {
    private IngredientCategory mCategory;
    public IngredientCategory Category
    {
      get { return mCategory; }
      set { SetField(ref mCategory, value); }
    }
  }
}
