using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NutritionCalc
{
  public partial class UnknownRecipeItemEdit : DevExpress.XtraEditors.XtraUserControl
  {
    public UnknownRecipeItemEdit()
    {
      InitializeComponent();
    }

    public IAddIngredient IngredientAdder { get; set; }
    public ICommitParseResult Committer { get; set; }

    public void Populate(IEnumerable<RecipeItemParseResult> results)
    {
      foreach (var value in results)
      {
        recipeItemParseResultBindingSource.Add(value);
      }
    }

    private async void RemoveResult(RecipeItemParseResult result)
    {
      await Task.Yield();
      recipeItemParseResultBindingSource.Remove(result);
    }

    private void btnAddIngredient_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      if (IngredientAdder != null &&
        Committer != null &&
        gridViewItems.GetFocusedRow() is RecipeItemParseResult result && 
        IngredientAdder.AddIngredient(result.SearchText, out Ingredient ingredient))
      {
        Committer.Commit(result, ingredient);
        RemoveResult(result);
      }
    }
  }
}
