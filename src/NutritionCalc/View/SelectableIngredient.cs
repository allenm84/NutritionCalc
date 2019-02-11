using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class SelectableIngredient : BaseNotifyPropertyChanged
  {
    private bool mIsSelected = false;

    public SelectableIngredient(BaseIngredient model)
    {
      Model = model;
    }

    public BaseIngredient Model { get; }

    public bool IsSelected
    {
      get { return mIsSelected; }
      set { SetField(ref mIsSelected, value); }
    }

    public string Name => Model.Name;
  }
}
