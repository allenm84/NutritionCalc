using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NutritionCalc
{
  public partial class NutritionViewDialog : BaseForm
  {
    public NutritionViewDialog(NutritionInfo info)
    {
      InitializeComponent();
      propertyGridControl1.SelectedObject = info;
    }
  }
}