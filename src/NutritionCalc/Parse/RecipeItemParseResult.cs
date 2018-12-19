using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class RecipeItemParseResult
  {
    public RecipeItemParseResult(RecipeItem item)
    {
      Item = item;
    }

    public RecipeItem Item { get; }
    public string Text => Item.Text;

    public bool Success { get; set; }
    public string SearchText { get; set; }
    public BaseIngredient[] Ingredients { get; set; }
    public decimal Quantity { get; set; }
    public Unit Unit { get; set; }
    public Exception Error { get; set; }

    public string ErrorMessage => GetErrorMessage();

    private string GetErrorMessage()
    {
      if (Success)
        return string.Empty;

      return Error?.Message ?? "Could not parse what you typed";
    }
  }
}
