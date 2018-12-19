using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public static class Enums<T>
  {
    static Enums()
    {
      Values = Enum.GetValues(typeof(T)).OfType<T>().ToArray();
    }

    public static T[] Values { get; }
  }
}
