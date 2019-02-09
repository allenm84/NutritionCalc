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
    private static readonly Regex[] sRegexAttempts;

    static RecipeItemParser()
    {
      // First, try to match what she typed to regex patterns:
      // * (\d+) (\d+\/\d+) (\w+) (\w+ )?(.+)   [2 1/4 Cups of Flour]
      // * (\d+\.\d+) (\w+) (\w+ )?(.+)         [2.25 Cups of Flour]
      // * (\d+) (\w+) (\w+ )?(.+)              [2 Cups of Flour]

      sRegexAttempts = new[]
      {
        new Regex(@"(?<n>\d+ )?(?<f>\d+\/\d+) (?<u>\w+) (?<of>\w+ )?(?<name>.+)", RegexOptions.IgnoreCase),
        new Regex(@"(?<n>(\d+)?\.\d+) (?<u>\w+) (?<of>\w+ )?(?<name>.+)", RegexOptions.IgnoreCase),
        new Regex(@"(?<n>\d+) (?<u>\w+) (?<of>\w+ )?(?<name>.+)", RegexOptions.IgnoreCase),
      };
    }

    private static IEnumerable<T> FindIngredient<T>(string name, T[] ingredients)
      where T : BaseIngredient
    {
      var words = name.Split(' ');
      var pattern = string.Join("|", words.Select(n => $"({n})"));
      var regex = new Regex(pattern, RegexOptions.IgnoreCase);
      return ingredients.Where(i => regex.IsMatch(i.Name));
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

      foreach (var r in sRegexAttempts)
      {
        var m = r.Match(item.Text);
        if (m.Success)
        {
          try
          {
            var quantity = 0m;
            var n = m.Groups["n"];
            if (n.Success)
            {
              quantity += decimal.Parse(n.Value);
            }

            var f = m.Groups["f"];
            if (f.Success)
            {
              var parts = f.Value.Split('/');
              quantity += decimal.Divide(decimal.Parse(parts[0]), decimal.Parse(parts[1]));
            }

            var searchText = m.Groups["name"].Value;
            result.SearchText = searchText;
            result.Quantity = quantity;
            result.Unit = Units.FindUnit(m.Groups["u"].Value);

            result.Ingredients = FindIngredient(searchText, ingredients).ToArray();
            result.Success = result.Ingredients.Length > 0;
            break;
          }
          catch (Exception ex)
          {
            result.Error = ex;
          }
        }
      }

      if (!result.Success)
      {

      }

      return result;
    }
  }
}
