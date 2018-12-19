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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

namespace NutritionCalc
{
  public partial class SelectableIngredientEdit : DevExpress.XtraEditors.XtraUserControl
  {
    public SelectableIngredientEdit()
    {
      InitializeComponent();
    }

    public string Amount
    {
      get => txtAmount.Text;
      set => txtAmount.Text = value;
    }

    public string Units
    {
      get => txtUnit.Text;
      set => txtUnit.Text = value;
    }

    public BaseIngredient Selected =>
      selectableIngredientBindingSource
      .OfType<SelectableIngredient>()
      .SingleOrDefault(i => i.IsSelected)?
      .Model;

    public void Populate(IEnumerable<BaseIngredient> ingredients)
    {
      foreach (var ingredient in ingredients)
      {
        selectableIngredientBindingSource.Add(new SelectableIngredient(ingredient));
      }
    }

    private async void UpdateSelection(SelectableIngredient selected)
    {
      await Task.Yield();
      foreach (var item in selectableIngredientBindingSource.OfType<SelectableIngredient>())
      {
        if (item == selected)
          continue;
        item.IsSelected = false;
      }
    }

    private void chkIsSelected_EditValueChanged(object sender, EventArgs e)
    {
      gridViewItems.CloseEditor();
    }

    private void selectableIngredientBindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemChanged &&
        selectableIngredientBindingSource[e.NewIndex] is SelectableIngredient selected &&
        selected.IsSelected)
      {
        UpdateSelection(selected);
      }
    }
  }
}
