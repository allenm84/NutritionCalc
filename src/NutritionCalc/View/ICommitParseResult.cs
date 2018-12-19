using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public interface ICommitParseResult
  {
    void Commit(RecipeItemParseResult result, Ingredient ingredient);
  }
}
