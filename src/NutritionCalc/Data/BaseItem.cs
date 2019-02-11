using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public abstract class BaseItem : BaseNotifyPropertyChanged, IHaveName
  {
    private string mId = null;
    public string Id
    {
      get
      {
        if (string.IsNullOrWhiteSpace(mId))
        {
          mId = $"{Guid.NewGuid()}";
        }
        return mId;
      }
      set { mId = value; }
    }

    private string mName;
    public string Name
    {
      get { return mName; }
      set { SetField(ref mName, value); }
    }
  }
}
