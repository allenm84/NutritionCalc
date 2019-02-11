using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.DXErrorProvider;

namespace NutritionCalc
{
  public class NutritionEditViewModel : BaseNotifyPropertyChanged
  {
    public NutritionEditViewModel()
    {
      Carbs.PropertyChanged += OnRelatedKetoCarbsPropertyChanged;
      Fiber.PropertyChanged += OnRelatedKetoCarbsPropertyChanged;
      AdditionalSugar.PropertyChanged += OnRelatedKetoCarbsPropertyChanged;
    }

    public DecimalTextValue Calories { get; } = new DecimalTextValue();
    public DecimalTextValue Fat { get; } = new DecimalTextValue();
    public DecimalTextValue Sodium { get; } = new DecimalTextValue();
    public DecimalTextValue Carbs { get; } = new DecimalTextValue();
    public DecimalTextValue Fiber { get; } = new DecimalTextValue();
    public DecimalTextValue Sugar { get; } = new DecimalTextValue();
    public DecimalTextValue AdditionalSugar { get; } = new DecimalTextValue();
    public DecimalTextValue Protein { get; } = new DecimalTextValue();

    private string mKetoCarbs;
    public string KetoCarbs
    {
      get => mKetoCarbs;
      set => SetField(ref mKetoCarbs, value);
    }

    public NutritionInfo Value
    {
      get => new NutritionInfo
      {
        Calories = Calories.Value,
        Fat = Fat.Value,
        Sodium = Sodium.Value,
        Carbs = Carbs.Value,
        Fiber = Fiber.Value,
        Sugar = Sugar.Value,
        AdditionalSugar = AdditionalSugar.Value,
        Protein = Protein.Value
      };
      set
      {
        Calories.Value = value.Calories;
        Fat.Value = value.Fat;
        Sodium.Value = value.Sodium;
        Carbs.Value = value.Carbs;
        Fiber.Value = value.Fiber;
        Sugar.Value = value.Sugar;
        AdditionalSugar.Value = value.AdditionalSugar;
        Protein.Value = value.Protein;
      }
    }

    private void UpdateKetoCarbs()
    {
      var carbs = Carbs.Value;
      var fibers = Fiber.Value;
      var addSugar = AdditionalSugar.Value;
      KetoCarbs = DecimalTextValue.AsText(carbs - (fibers + addSugar));
    }

    private void OnRelatedKetoCarbsPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      UpdateKetoCarbs();
    }
  }
}
