﻿using System;
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
  public partial class BaseForm : DevExpress.XtraEditors.XtraForm
  {
    protected bool mCancelClose = false;

    public BaseForm()
    {
      InitializeComponent();
    }

    protected virtual CustomDialogResult? InternalCustomDialogResult { get; set; } = null;

    public void ShowCentered(IWin32Window owner = null)
    {
      Show(owner);
      CenterToScreen();
    }

    protected bool Confirm(string message, string caption = "Confirm")
    {
      var result = XtraMessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      return (result == DialogResult.Yes);
    }

    protected void Inform(string message, string caption = "Inform")
    {
      XtraMessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    protected void ShowError(string message, string caption = "Error")
    {
      XtraMessageBox.Show(this, message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public virtual CustomDialogResult ShowDialogCustom(IWin32Window owner = null)
    {
      var result = ShowDialog(owner);
      return InternalCustomDialogResult ?? result.ToCustomDialogResult();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (mCancelClose)
      {
        e.Cancel = true;
        mCancelClose = false;
      }
      base.OnFormClosing(e);
    }
  }
}