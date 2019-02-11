using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public struct NutritionInfo
  {
    public decimal Calories { get; set; }
    public decimal Fat { get; set; }
    public decimal Sodium { get; set; }
    public decimal Carbs { get; set; }
    public decimal Fiber { get; set; }
    public decimal Sugar { get; set; }
    public decimal AdditionalSugar { get; set; }
    public decimal Protein { get; set; }

    public override int GetHashCode()
    {
      return string.Join(",", Calories, Fat, Sodium, Carbs, Fiber, Sugar, AdditionalSugar, Protein).GetHashCode();
    }

    public override bool Equals(object obj)
    {
      return (obj is NutritionInfo other) && Equals(this, other);
    }

    public static bool Equals(NutritionInfo value1, NutritionInfo value2)
    {
      if (value1.Calories != value2.Calories) return false;
      if (value1.Fat != value2.Fat) return false;
      if (value1.Sodium != value2.Sodium) return false;
      if (value1.Carbs != value2.Carbs) return false;
      if (value1.Fiber != value2.Fiber) return false;
      if (value1.Sugar != value2.Sugar) return false;
      if (value1.AdditionalSugar != value2.AdditionalSugar) return false;
      if (value1.Protein != value2.Protein) return false;

      return true;
    }

    public static NutritionInfo operator -(NutritionInfo value)
    {
      value.Calories = -value.Calories;
      value.Fat = -value.Fat;
      value.Sodium = -value.Sodium;
      value.Carbs = -value.Carbs;
      value.Fiber = -value.Fiber;
      value.Sugar = -value.Sugar;
      value.AdditionalSugar = -value.AdditionalSugar;
      value.Protein = -value.Protein;
      return value;
    }

    public static bool operator ==(NutritionInfo value1, NutritionInfo value2)
    {
      return Equals(value1, value2);
    }
    
    public static bool operator !=(NutritionInfo value1, NutritionInfo value2)
    {
      return !Equals(value1, value2);
    }

    public static NutritionInfo operator +(NutritionInfo value1, NutritionInfo value2)
    {
      value1.Calories += value2.Calories;
      value1.Fat += value2.Fat;
      value1.Sodium += value2.Sodium;
      value1.Carbs += value2.Carbs;
      value1.Fiber += value2.Fiber;
      value1.Sugar += value2.Sugar;
      value1.AdditionalSugar += value2.AdditionalSugar;
      value1.Protein += value2.Protein;
      return value1;
    }

    public static NutritionInfo operator -(NutritionInfo value1, NutritionInfo value2)
    {
      value1.Calories -= value2.Calories;
      value1.Fat -= value2.Fat;
      value1.Sodium -= value2.Sodium;
      value1.Carbs -= value2.Carbs;
      value1.Fiber -= value2.Fiber;
      value1.Sugar -= value2.Sugar;
      value1.AdditionalSugar -= value2.AdditionalSugar;
      value1.Protein -= value2.Protein;
      return value1;
    }

    public static NutritionInfo operator *(NutritionInfo value1, NutritionInfo value2)
    {
      value1.Calories *= value2.Calories;
      value1.Fat *= value2.Fat;
      value1.Sodium *= value2.Sodium;
      value1.Carbs *= value2.Carbs;
      value1.Fiber *= value2.Fiber;
      value1.Sugar *= value2.Sugar;
      value1.AdditionalSugar *= value2.AdditionalSugar;
      value1.Protein *= value2.Protein;
      return value1;
    }

    public static NutritionInfo operator *(NutritionInfo value, decimal scaleFactor)
    {
      value.Calories *= scaleFactor;
      value.Fat *= scaleFactor;
      value.Sodium *= scaleFactor;
      value.Carbs *= scaleFactor;
      value.Fiber *= scaleFactor;
      value.Sugar *= scaleFactor;
      value.AdditionalSugar *= scaleFactor;
      value.Protein *= scaleFactor;
      return value;
    }

    public static NutritionInfo operator *(decimal scaleFactor, NutritionInfo value)
    {
      value.Calories *= scaleFactor;
      value.Fat *= scaleFactor;
      value.Sodium *= scaleFactor;
      value.Carbs *= scaleFactor;
      value.Fiber *= scaleFactor;
      value.Sugar *= scaleFactor;
      value.AdditionalSugar *= scaleFactor;
      value.Protein *= scaleFactor;
      return value;
    }

    public static NutritionInfo operator /(NutritionInfo value1, NutritionInfo value2)
    {
      value1.Calories /= value2.Calories;
      value1.Fat /= value2.Fat;
      value1.Sodium /= value2.Sodium;
      value1.Carbs /= value2.Carbs;
      value1.Fiber /= value2.Fiber;
      value1.Sugar /= value2.Sugar;
      value1.AdditionalSugar /= value2.AdditionalSugar;
      value1.Protein /= value2.Protein;
      return value1;
    }

    public static NutritionInfo operator /(NutritionInfo value, decimal divider)
    {
      value.Calories /= divider;
      value.Fat /= divider;
      value.Sodium /= divider;
      value.Carbs /= divider;
      value.Fiber /= divider;
      value.Sugar /= divider;
      value.AdditionalSugar /= divider;
      value.Protein /= divider;
      return value;
    }
  }
}
