using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class CustomUnit : Unit
  {
    public override decimal Factor => 1;

    public override bool CanConvertTo(Unit other)
    {
      return (other is CustomUnit) && IsEqual(other);
    }
  }
}
