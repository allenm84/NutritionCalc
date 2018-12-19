using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class SelectableIngredient : INotifyPropertyChanged
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
      set
      {
        mIsSelected = value;
        FirePropertyChanged();
      }
    }

    public string Name => Model.Name;

    public event PropertyChangedEventHandler PropertyChanged;

    private void FirePropertyChanged([CallerMemberName]string name = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
  }
}
