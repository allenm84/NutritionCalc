﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NutritionCalc
{
  public static class Extensions
  {
    public static IEnumerable<T> Enumerate<T>(this T value)
    {
      yield return value;
    }

    public static object At(this BindingSource source, int index)
    {
      if (-1 < index && index < source.Count)
      {
        return source[index];
      }

      return null;
    }

    public static string N2(this decimal value)
    {
      return $"{value:N2}";
    }

    public static bool TryMatch(this Regex regex, string input, out Match match)
    {
      match = regex.Match(input);
      return match.Success;
    }

    public static T Clone<T>(this T value)
    {
      var json = JsonConvert.SerializeObject(value);
      var obj = JsonConvert.DeserializeObject(json);
      return (obj is T retval) ? retval : value;
    }

    public static decimal Value(this DevExpress.XtraEditors.TextEdit textBox)
    {
      return decimal.TryParse(textBox.Text, out decimal result) ? result : 0;
    }

    public static CustomDialogResult ToCustomDialogResult(this DialogResult result)
    {
      switch (result)
      {
        case DialogResult.Abort:
          return CustomDialogResult.Abort;
        case DialogResult.Cancel:
          return CustomDialogResult.Cancel;
        case DialogResult.Ignore:
          return CustomDialogResult.Ignore;
        case DialogResult.No:
          return CustomDialogResult.No;
        case DialogResult.OK:
          return CustomDialogResult.OK;
        case DialogResult.Retry:
          return CustomDialogResult.Retry;
        case DialogResult.Yes:
          return CustomDialogResult.Yes;
        default:
        case DialogResult.None:
          return CustomDialogResult.None;
      }
    }
  }
}
