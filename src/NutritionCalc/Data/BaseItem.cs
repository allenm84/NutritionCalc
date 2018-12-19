﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public abstract class BaseItem : IHaveName, INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    public string Id { get; } = $"{Guid.NewGuid()}";

    private string mName;
    public string Name
    {
      get { return mName; }
      set { SetField(ref mName, value); }
    }

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