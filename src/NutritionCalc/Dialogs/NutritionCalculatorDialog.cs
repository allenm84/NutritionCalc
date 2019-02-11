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
  public partial class NutritionCalculatorDialog : BaseForm
  {
    private readonly DecimalTextValue mServingSizeAmount = new DecimalTextValue();

    public NutritionCalculatorDialog(NutritionCalcData data)
    {
      InitializeComponent();
      foreach (var value in data.All)
      {
        baseIngredientBindingSource.Add(value);
      }

      mServingSizeAmount.PropertyChanged += OnServingSizeChanged;
      numServingAmount.DataBindings.Add(nameof(TextEdit.Text),
        mServingSizeAmount,
        nameof(DecimalTextValue.Text));

      var lookup = cboUnits.Properties;
      lookup.ShowHeader = false;
      lookup.ShowLines = false;
      lookup.DisplayMember = nameof(Unit.Display);
      lookup.Columns.Add(new LookUpColumnInfo(nameof(Unit.Display), "Text")
      {
        SortOrder = ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    private void OnServingSizeChanged(object sender, PropertyChangedEventArgs e)
    {
      var error = string.Empty;
      if (mServingSizeAmount.IsValid)
      {
        if (mServingSizeAmount.Value <= 0)
        {
          error = Resources.SevingSizeCannotBeZeroErrorText;
        }
      }
      else
      {
        error = Resources.NotANumberErrorText;
      }
      dxErrorProvider1.SetError(numServingAmount, error);
    }

    private bool TryGetServingSize(BaseIngredient ingredient, Unit unit, out IServingSize serving)
    {
      serving = null;

      if (unit is WeightUnit weight)
      {
        serving = ingredient.ServingSizeWeight;
      }
      else if (unit is VolumeUnit volume)
      {
        serving = ingredient.ServingSizeVolume;
      }
      else if (unit is CustomUnit custom)
      {
        serving = ingredient.ServingSizeCustom;
      }

      return (serving?.Unit != null);
    }

    private void cboItems_EditValueChanged(object sender, EventArgs e)
    {
      if (cboItems.EditValue is BaseIngredient ingredient)
      {
        lcgNutritionInfo.Text = $"{ingredient.Name} Nutrition";
        nutritionInfoEdit.ReadFrom(ingredient);

        var units = Enumerable.Empty<Unit>();
        if (ingredient.ServingSizeWeight.Unit != null)
        {
          units = units.Concat(Units.Weight);
        }
        if (ingredient.ServingSizeVolume.Unit != null)
        {
          units = units.Concat(Units.Volume);
        }
        if (ingredient.ServingSizeCustom.Unit != null)
        {
          units = units.Concat(ingredient.ServingSizeCustom.Unit.Enumerate());
        }

        cboUnits.Properties.DataSource = units.ToArray();
      }
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      if (!mServingSizeAmount.IsValid)
      {
        return;
      }

      if (cboItems.EditValue is BaseIngredient ingredient)
      {
        if (cboUnits.EditValue is Unit unit && TryGetServingSize(ingredient, unit, out var serving))
        {
          try
          {
            var currentAmount = serving.Unit.Factor * serving.Amount;
            var desiredAmount = unit.Factor * mServingSizeAmount.Value;
            var factor = desiredAmount / currentAmount;
            var nutrition = ingredient.Nutrition * factor;

            var view = new NutritionViewDialog(nutrition);
            view.ShowCentered(this);
          }
          catch
          {
            ShowError($"There was an error while calculating the nutrition. Make sure you entered a non-zero amount for {layoutControlGroup3.Text}");
          }
        }
        else
        {
          ShowError($"Please select a desired unit. Make sure that {ingredient.Name} has at least 1 valid serving size defined.");
        }
      }
      else
      {
        ShowError("Please select an Ingredient, Base Recipe, or Recipe from the dropdown.");
      }
    }
  }
}