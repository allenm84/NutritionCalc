using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCalc
{
  public class GroupedItemViewEventArgs : EventArgs
  {
    public GroupedItemViewEventArgs(object category, object item)
    {
      Category = category;
      Item = item;
    }

    public object Category { get; }
    public object Item { get; }
  }
}
