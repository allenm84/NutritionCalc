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
using DevExpress.Data;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using NutritionCalc.Properties;

namespace NutritionCalc
{
  public partial class NutritionInfoEdit : DevExpress.XtraEditors.XtraUserControl
  {
    private readonly NutritionEditViewModel mViewModel = new NutritionEditViewModel();

    private readonly DecimalTextValue mWeight = new DecimalTextValue();
    private readonly DecimalTextValue mVolume = new DecimalTextValue();
    private readonly DecimalTextValue mCustom = new DecimalTextValue();

    private bool mCanEditNutrition = true;

    public NutritionInfoEdit()
    {
      InitializeComponent();
      if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
      {
        InitializeUnits();
        
        Bind(mWeight, numServingSizeWeight);
        Bind(mVolume, numServingSizeVolume);
        Bind(mCustom, numServingSizeCustom);

        Bind(mViewModel.Calories, numCalories);
        Bind(mViewModel.Fat, numFat);
        Bind(mViewModel.Sodium, numSodium);
        Bind(mViewModel.Carbs, numCarbs);
        Bind(mViewModel.Fiber, numFiber);
        Bind(mViewModel.Sugar, numSugar);
        Bind(mViewModel.AdditionalSugar, numAdditionalSugar);
        Bind(mViewModel.Protein, numProtein);
        txtKetoCarbs.DataBindings.Add(nameof(TextEdit.Text), mViewModel, nameof(NutritionEditViewModel.KetoCarbs));
      }
    }

    [DefaultValue(true)]
    public bool CanEditNutrition
    {
      get => mCanEditNutrition;
      set
      {
        mCanEditNutrition = value;
        UpdateNutrition();
      }
    }

    [Browsable(false)]
    public NutritionInfo Nutrition => mViewModel.Value;

    private void InitializeUnits()
    {
      PopulateLookUp(cboWeightUnits, Units.Weight);
      PopulateLookUp(cboVolumeUnits, Units.Volume);
      PopulateLookUp(cboCustomUnits, Units.Custom);
    }

    private void Bind(DecimalTextValue value, TextEdit text)
    {
      text.DataBindings.Add(nameof(TextEdit.Text), value, nameof(DecimalTextValue.Text));
      value.PropertyChanged += (sender, e) =>
      {
        var error = value.IsValid ?
          string.Empty :
          Resources.NotANumberErrorText;
        dxErrorProvider1.SetError(text, error);
      };
    }

    private static void PopulateLookUp<T>(LookUpEdit cboUnits, IEnumerable<T> units) where T : Unit
    {
      var lookup = cboUnits.Properties;
      lookup.ShowHeader = false;
      lookup.ShowLines = false;
      lookup.DataSource = units.ToArray();
      lookup.DisplayMember = nameof(Unit.Display);
      lookup.Columns.Add(new LookUpColumnInfo(nameof(Unit.Display), "Text")
      {
        SortOrder = ColumnSortOrder.Ascending,
        Visible = true,
      });
    }

    private void UpdateNutrition()
    {
      numCalories.ReadOnly = !mCanEditNutrition;
      numFat.ReadOnly = !mCanEditNutrition;
      numSodium.ReadOnly = !mCanEditNutrition;
      numCarbs.ReadOnly = !mCanEditNutrition;
      numFiber.ReadOnly = !mCanEditNutrition;
      numSugar.ReadOnly = !mCanEditNutrition;
      numAdditionalSugar.ReadOnly = !mCanEditNutrition;
      numProtein.ReadOnly = !mCanEditNutrition;
    }

    public void ReadFrom(BaseIngredient ingredient)
    {
      mWeight.Value = ingredient.ServingSizeWeight.Amount;
      cboWeightUnits.EditValue = ingredient.ServingSizeWeight.Unit;

      mVolume.Value = ingredient.ServingSizeVolume.Amount;
      cboVolumeUnits.EditValue = ingredient.ServingSizeVolume.Unit;

      mCustom.Value = ingredient.ServingSizeCustom.Amount;
      cboCustomUnits.EditValue = ingredient.ServingSizeCustom.Unit;

      ReadNutrition(ingredient.Nutrition);
    }

    public void ReadNutrition(NutritionInfo nutrition)
    {
      mViewModel.Value = nutrition;
    }

    public void WriteTo(BaseIngredient ingredient)
    {
      if (cboWeightUnits.EditValue is WeightUnit weight)
      {
        ingredient.ServingSizeWeight = new ServingSize<WeightUnit> { Amount = mWeight.Value, Unit = weight };
      }

      if (cboVolumeUnits.EditValue is VolumeUnit volume)
      {
        ingredient.ServingSizeVolume = new ServingSize<VolumeUnit> { Amount = mVolume.Value, Unit = volume };
      }

      if (cboCustomUnits.EditValue is CustomUnit custom)
      {
        ingredient.ServingSizeCustom = new ServingSize<CustomUnit> { Amount = mCustom.Value, Unit = custom };
      }

      ingredient.Nutrition = Nutrition;
    }

    public string GetErrorText()
    {
      if (dxErrorProvider1.HasErrors)
      {
        return Resources.PleaseFixNutritionErrorText;
      }
      else if (mWeight.Value <= 0 && mVolume.Value <= 0 && mCustom.Value <= 0)
      {
        return "There needs to be at least 1 non-zero serving size";
      }
      else
      {
        return string.Empty;
      }
    }
  }
}
