using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class VolumeUnit : Unit
  {
    public decimal AsTeaspoons { get; set; }

    public override decimal Factor => AsTeaspoons;

    public override bool CanConvertTo(Unit other)
    {
      return other is VolumeUnit;
    }
  }
}
