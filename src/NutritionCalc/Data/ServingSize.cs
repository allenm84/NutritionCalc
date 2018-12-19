using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public struct ServingSize<T> where T : Unit
  {
    public decimal Amount { get; set; }
    public T Unit { get; set; }
  }
}
