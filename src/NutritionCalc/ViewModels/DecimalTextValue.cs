using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.DXErrorProvider;

namespace NutritionCalc
{
  public class DecimalTextValue : BaseNotifyPropertyChanged
  {
    private readonly HashSet<string> mTokens = new HashSet<string>();

    private bool mIsValid;
    public bool IsValid
    {
      get => mIsValid;
      private set => SetField(ref mIsValid, value);
    }

    private decimal mValue;
    public decimal Value
    {
      get => mValue;
      set
      {
        if (TryGetToken(out var token))
        {
          SetField(ref mValue, value);
          Text = AsText(mValue);
          mTokens.Remove(token);
        }
      }
    }

    private string mText;
    public string Text
    {
      get => mText;
      set
      {
        if (TryGetToken(out var token))
        {
          SetField(ref mText, value);
          if (decimal.TryParse(mText, out var parsed))
          {
            Value = parsed;
            IsValid = true;
          }
          else
          {
            IsValid = false;
          }
          mTokens.Remove(token);
        }
      }
    }

    private bool TryGetToken(out string token, [CallerMemberName] string name = "")
    {
      token = name;
      return mTokens.Add(token);
    }

    public static string AsText(decimal value)
    {
      return $"{Math.Round(value, 2)}";
    }
  }
}
