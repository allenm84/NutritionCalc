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
using DevExpress.Data;
using NutritionCalc.Properties;

namespace NutritionCalc
{
  public partial class EditIngredientDialog : BaseForm
  {
    public EditIngredientDialog()
    {
      InitializeComponent();
      PopulateCategories();
      cboCategory.Properties.NullText = " ";
    }

    private void PopulateCategories()
    {
      var lookup = cboCategory.Properties;
      lookup.ShowHeader = false;
      lookup.ShowLines = false;
      lookup.DataSource = Enums<IngredientCategory>.Values.Select(v => new { Value = v, Display = $"{v}" });
      lookup.DisplayMember = "Display";
      lookup.ValueMember = "Value";
      lookup.Columns.Add(new LookUpColumnInfo("Display", "Text")
      {
        SortOrder = ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    public void ReadFrom(bool canDelete, Ingredient ingredient, bool selectCategory)
    {
      layoutControlItem6.ContentVisible = canDelete;
      txtName.Text = ingredient.Name;
      if (selectCategory)
      {
        cboCategory.EditValue = ingredient.Category;
      }
      nutritionInfoEdit.ReadFrom(ingredient);
    }

    public void WriteTo(Ingredient ingredient)
    {
      ingredient.Name = txtName.Text;
      if (cboCategory.EditValue is IngredientCategory category)
      {
        ingredient.Category = category;
      }
      nutritionInfoEdit.WriteTo(ingredient);
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
      if (keyData == Keys.Enter && ControlHelper.TryGetFocusedControl(out Control control))
      {
        SelectNextControl(control, true, true, true, true);
        return true;
      }
      else
      {
        return base.ProcessDialogKey(keyData);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (Confirm("Are you sure you want to delete this ingredient?"))
      {
        InternalCustomDialogResult = CustomDialogResult.Delete;
        Close();
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      var errorText = nutritionInfoEdit.GetErrorText();
      if (!string.IsNullOrWhiteSpace(errorText))
      {
        ShowError(errorText);
        mCancelClose = true;
      }
    }
  }
}