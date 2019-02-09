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
using DevExpress.XtraEditors.Controls;

namespace NutritionCalc
{
  public partial class ResetRecipeItemsDialog : BaseForm
  {
    public ResetRecipeItemsDialog(IEnumerable<RecipeItem> items)
    {
      InitializeComponent();
      foreach (var item in items.OrderBy(i => i.Text))
      {
        lstItems.Items.Add(new RecipeItemListItem(item), true);
      }
    }

    public IEnumerable<RecipeItem> CheckedItems => lstItems.CheckedItems
      .OfType<CheckedListBoxItem>()
      .Select(i => i.Value as RecipeItemListItem)
      .Select(i => i?.Item)
      .Where(i => i != null);

    private class RecipeItemListItem
    {
      public RecipeItemListItem(RecipeItem item) => Item = item;
      public RecipeItem Item { get; }
      public override string ToString() => Item?.Text;
    }
  }
}