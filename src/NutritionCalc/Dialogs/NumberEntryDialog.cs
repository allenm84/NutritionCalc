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
  public partial class NumberEntryDialog : BaseForm
  {
    public NumberEntryDialog()
    {
      InitializeComponent();
    }

    public string Prompt
    {
      get => lblPrompt.Text;
      set => lblPrompt.Text = value;
    }

    public decimal Value
    {
      get => numValue.Value;
      set => numValue.Value = value;
    }
  }
}