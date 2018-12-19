using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCalc
{
  public static class ControlHelper
  {
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
    private static extern IntPtr GetFocus();

    public static Control GetFocusedControl()
    {
      Control focusedControl = null;
      // To get hold of the focused control:
      IntPtr focusedHandle = GetFocus();
      if (focusedHandle != IntPtr.Zero)
        // Note that if the focused Control is not a .Net control, then this will return null.
        focusedControl = Control.FromHandle(focusedHandle);
      return focusedControl;
    }

    public static bool TryGetFocusedControl(out Control control)
    {
      control = GetFocusedControl();
      return (control != null);
    }
  }
}
