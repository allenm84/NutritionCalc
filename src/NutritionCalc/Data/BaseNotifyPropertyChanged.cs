using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public abstract class BaseNotifyPropertyChanged : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      PropertyChanged?.Invoke(this, e);
    }

    protected void SetField<T>(ref T field, T value, [CallerMemberName] string name = "")
    {
      field = value;
      OnPropertyChanged(new PropertyChangedEventArgs(name));
    }
  }
}
