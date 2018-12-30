using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class WeightUnit : Unit
  {
    public decimal AsGrams { get; set; }

    public override decimal Factor => AsGrams;
  }
}
