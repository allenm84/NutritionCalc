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

namespace NutritionCalc
{
  public partial class NutritionInfoEdit : DevExpress.XtraEditors.XtraUserControl
  {
    private bool mCanEditNutrition = true;

    public NutritionInfoEdit()
    {
      InitializeComponent();
      if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
      {
        InitializeUnits();
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
    public NutritionInfo Nutrition => new NutritionInfo
    {
      AdditionalSugar = numAdditionalSugar.Value(),
      Calories = numCalories.Value(),
      Carbs = numCarbs.Value(),
      Fat = numFat.Value(),
      Fiber = numFiber.Value(),
      Protein = numProtein.Value(),
      Sodium = numSodium.Value(),
      Sugar = numSugar.Value(),
    };

    private void InitializeUnits()
    {
      PopulateLookUp(cboWeightUnits, Units.Weight);
      PopulateLookUp(cboVolumeUnits, Units.Volume);
      PopulateLookUp(cboCustomUnits, Units.Custom);
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

    private void CalculateKetoCarbs()
    {
      var carbs = numCarbs.Value();
      var fibers = numFiber.Value();
      var addSugar = numAdditionalSugar.Value();
      txtKetoCarbs.Text = $"{carbs - (fibers + addSugar)}";
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
      numServingSizeWeight.Text = ingredient.ServingSizeWeight.Amount.N2();
      cboWeightUnits.EditValue = ingredient.ServingSizeWeight.Unit;

      numServingSizeVolume.Text = ingredient.ServingSizeVolume.Amount.N2();
      cboVolumeUnits.EditValue = ingredient.ServingSizeVolume.Unit;

      numServingSizeCustom.Text = ingredient.ServingSizeCustom.Amount.N2();
      cboCustomUnits.EditValue = ingredient.ServingSizeCustom.Unit;

      ReadNutrition(ingredient.Nutrition);
    }

    public void ReadNutrition(NutritionInfo nutrition)
    {
      numCalories.Text = nutrition.Calories.N2();
      numFat.Text = nutrition.Fat.N2();
      numSodium.Text = nutrition.Sodium.N2();
      numCarbs.Text = nutrition.Carbs.N2();
      numFiber.Text = nutrition.Fiber.N2();
      numSugar.Text = nutrition.Sugar.N2();
      numAdditionalSugar.Text = nutrition.AdditionalSugar.N2();
      numProtein.Text = nutrition.Protein.N2();
    }

    public void WriteTo(BaseIngredient ingredient)
    {
      if (cboWeightUnits.EditValue is WeightUnit weight)
      {
        ingredient.ServingSizeWeight = new ServingSize<WeightUnit> { Amount = numServingSizeWeight.Value(), Unit = weight };
      }

      if (cboVolumeUnits.EditValue is VolumeUnit volume)
      {
        ingredient.ServingSizeVolume = new ServingSize<VolumeUnit> { Amount = numServingSizeVolume.Value(), Unit = volume };
      }

      if (cboCustomUnits.EditValue is CustomUnit custom)
      {
        ingredient.ServingSizeCustom = new ServingSize<CustomUnit> { Amount = numServingSizeCustom.Value(), Unit = custom };
      }

      ingredient.Nutrition = Nutrition;
    }

    private void num_TextChanged(object sender, EventArgs e)
    {
      CalculateKetoCarbs();
    }
  }
}
