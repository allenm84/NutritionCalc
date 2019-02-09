using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public static class RecipeItemParser
  {
    private static readonly Regex sFraction = 
      new Regex(@"(?<fraction>(?<whole>\d+ )?(?<numerator>\d+)\/(?<denominator>\d+))(?<text>.+)?", RegexOptions.Compiled);

    private static readonly Regex sDecimal =
      new Regex(@"(?<decimal>\d+\.\d+)(?<text>.+)?", RegexOptions.Compiled);

    private static readonly Regex sInteger =
      new Regex(@"(?<int>\d+)(?<text>.+)?", RegexOptions.Compiled);

    private static IEnumerable<T> FindIngredient<T>(string name, T[] ingredients)
      where T : BaseIngredient
    {
      var words = name.Split(' ');
      var pattern = string.Join("|", words.Select(n => $"({n})"));
      var regex = new Regex(pattern, RegexOptions.IgnoreCase);
      return ingredients.Where(i => regex.IsMatch(i.Name));
    }

    private static bool TryParseQuantity(string input, out (decimal quantity, string remainingText) result)
    {
      var value = 0m;
      var text = string.Empty;
      var success = true;

      try
      {
        if (sFraction.TryMatch(input, out var fracMatch))
        {
          value = 0;
          var whole = fracMatch.Groups["whole"].Value.Trim();
          if (!string.IsNullOrWhiteSpace(whole))
          {
            value = decimal.Parse(whole);
          }

          var numerator = decimal.Parse(fracMatch.Groups["numerator"].Value);
          var denominator = decimal.Parse(fracMatch.Groups["denominator"].Value);
          value += decimal.Divide(numerator, denominator);
          text = GetText(fracMatch);
        }
        else if (sDecimal.TryMatch(input, out var decMatch))
        {
          value = decimal.Parse(decMatch.Groups["decimal"].Value);
          text = GetText(decMatch);
        }
        else if (sInteger.TryMatch(input, out var intMatch))
        {
          value = decimal.Parse(intMatch.Groups["int"].Value);
          text = GetText(intMatch);
        }
        else
        {
          success = false;
        }
      }
      catch
      {
        success = false;
      }

      result = (value, text);
      return success;

      string GetText(Match m) => m.Groups["text"].Value;
    }

    private static bool TryParseUnit(string input, out Unit unit)
    {
      unit = null;
      
      var words = input.Split(' ').ToList();
      for (int i = 0; unit == null && i < words.Count; ++i)
      {
        var word = words[i];
        if (string.Equals("of", word, StringComparison.OrdinalIgnoreCase))
        {
          continue;
        }

        unit = Units.GetUnit(word);
      }

      return (unit != null);
    }

    public static IEnumerable<RecipeItemParseResult> Run<T>(IEnumerable<RecipeItem> items, IEnumerable<T> pool)
      where T : BaseIngredient
    {
      var ingredients = pool.ToArray();
      foreach (var item in items)
      {
        yield return Parse(item, ingredients);
      }
    }

    public static RecipeItemParseResult Run<T>(RecipeItem item, IEnumerable<T> pool)
      where T : BaseIngredient
    {
      return Parse(item, pool.ToArray());
    }

    private static RecipeItemParseResult Parse<T>(RecipeItem item, T[] ingredients)
      where T : BaseIngredient
    {
      var result = new RecipeItemParseResult(item);

      if (TryParseQuantity(item.Text, out var value))
      {
        var text = value.remainingText.Trim();
        if (TryParseUnit(text, out var unit))
        {
          result.SearchText = text;
          result.Quantity = value.quantity;
          result.Unit = unit;
          result.Ingredients = FindIngredient(text, ingredients).ToArray();
          result.Success = result.Ingredients.Length > 0;
        }
        else
        {
          result.Error = new Exception($"Couldn't find unit within the text '{text}'");
          result.Success = false;
        }
      }
      else
      {
        result.Error = new Exception($"Couldn't get the quantity from '{item.Text}'");
        result.Success = false;
      }

      return result;
    }
  }
}
