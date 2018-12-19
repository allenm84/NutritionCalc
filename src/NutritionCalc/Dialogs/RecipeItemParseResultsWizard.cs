using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraWizard;

namespace NutritionCalc
{
  public partial class RecipeItemParseResultsWizard : BaseForm, ICommitParseResult
  {
    private WizardControl mWizard;
    private List<Action> mCommitActions = new List<Action>();
    private readonly IAddIngredient mIngredientAdder;

    public RecipeItemParseResultsWizard(IAddIngredient ingredientAdder, params RecipeItemParseResult[] results)
      : this(ingredientAdder, results.Select(r => r))
    {
    }

    public RecipeItemParseResultsWizard(IAddIngredient ingredientAdder, IEnumerable<RecipeItemParseResult> results)
    {
      mIngredientAdder = ingredientAdder;
      InitializeComponent();

      mWizard = new WizardControl();
      mWizard.Dock = DockStyle.Fill;
      Controls.Add(mWizard);

      var lookup = results.ToLookup(r => r.Success);
      foreach (var result in lookup[true])
      {
        var editor = new SelectableIngredientEdit();
        editor.Amount = $"{result.Quantity}";
        editor.Units = $"{result.Unit.Display}";
        editor.Populate(result.Ingredients);
        editor.Dock = DockStyle.Fill;

        Action onCommit = () => UpdateResult(result, editor.Selected);
        mCommitActions.Add(onCommit);

        var page = new WizardPage();
        page.DescriptionText = "Select the ingredient that matches what you entered";
        page.Text = result.Item.Text;
        page.Controls.Add(editor);

        mWizard.Pages.Add(page);
      }

      var failures = lookup[false].ToArray();
      if (failures.Length > 0)
      {
        var failureEditor = new UnknownRecipeItemEdit();
        failureEditor.Populate(failures);
        failureEditor.Dock = DockStyle.Fill;
        failureEditor.IngredientAdder = mIngredientAdder;
        failureEditor.Committer = this;

        var failurePage = new WizardPage();
        failurePage.DescriptionText = "The following item(s) could not be found";
        failurePage.Text = "Failed to find";
        failurePage.Controls.Add(failureEditor);
        mWizard.Pages.Add(failurePage);
      }

      mWizard.SelectedPageIndex = 0;
    }

    private void UpdateResult(RecipeItemParseResult result, BaseIngredient ingredient)
    {
      var (id, typename) = Units.ToSelection(result.Unit);
      var item = result.Item;
      item.ItemId = ingredient?.Id;
      item.Quantity = result.Quantity;
      item.UnitId = id;
      item.UnitTypeName = typename;
    }

    public void Commit()
    {
      mCommitActions.ForEach(c => c.Invoke());
    }

    void ICommitParseResult.Commit(RecipeItemParseResult result, Ingredient ingredient)
    {
      UpdateResult(result, ingredient);
    }
  }
}