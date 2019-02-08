using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public abstract class Unit : IEquatable<Unit>
  {
    public string Name { get; set; }
    public string Display { get; set; }

    public abstract decimal Factor { get; }

    protected bool IsEqual(Unit other)
    {
      return 
        string.Equals(Name, other.Name, StringComparison.Ordinal) && 
        string.Equals(Display, other.Display, StringComparison.Ordinal);
    }

    public abstract bool CanConvertTo(Unit other);

    public override int GetHashCode()
    {
      return $"{Name}::{Display}".GetHashCode();
    }

    public override bool Equals(object obj)
    {
      return (obj is Unit unit) && IsEqual(unit);
    }

    bool IEquatable<Unit>.Equals(Unit other)
    {
      return IsEqual(other);
    }
  }
}
