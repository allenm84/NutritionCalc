using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class BaseIngredient : BaseItem
  {
    public ServingSize<WeightUnit> ServingSizeWeight { get; set; }
    public ServingSize<VolumeUnit> ServingSizeVolume { get; set; }
    public ServingSize<CustomUnit> ServingSizeCustom { get; set; }
    public NutritionInfo Nutrition { get; set; }
  }
}
