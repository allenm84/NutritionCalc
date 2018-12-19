using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class RecipeItem
  {
    /// <summary> The original text that the user entered. </summary>
    public string Text { get; set; }

    /// <summary> The BaseIngredient assigned to this item. </summary>
    public string ItemId { get; set; }

    /// <summary> The quantity of the item. </summary>
    public decimal Quantity { get; set; }

    /// <summary> The type name of the <see cref="Unit"/>. </summary>
    public string UnitTypeName { get; set; }

    /// <summary> The <see cref="Unit.Name"/> of the <see cref="Unit"/>. </summary>
    public string UnitId { get; set; }
  }
}
