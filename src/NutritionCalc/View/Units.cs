using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NutritionCalc
{
  public static class Units
  {
    static readonly WeightUnit[] sWeight;
    static readonly VolumeUnit[] sVolume;
    static readonly CustomUnit[] sCustom;
    static readonly Dictionary<(string id, string typename), Unit> sSelectionToUnit;

    static Units()
    {
      sWeight = LoadUnits<WeightUnit>("units_weight.json");
      sVolume = LoadUnits<VolumeUnit>("units_volume.json");
      sCustom = LoadUnits<CustomUnit>("units_custom.json");
      sSelectionToUnit = All.ToDictionary(u => ToSelection(u));
    }

    static T[] LoadUnits<T>(string filepath)
    {
      if (!File.Exists(filepath))
      {
        return new T[0];
      }
      else
      {
        return JsonConvert.DeserializeObject<T[]>(File.ReadAllText(filepath));
      }
    }

    public static IEnumerable<WeightUnit> Weight => sWeight;
    public static IEnumerable<VolumeUnit> Volume => sVolume;
    public static IEnumerable<CustomUnit> Custom => sCustom;

    public static IEnumerable<Unit> All
    {
      get
      {
        foreach (var w in sWeight) yield return w;
        foreach (var v in sVolume) yield return v;
        foreach (var c in sCustom) yield return c;
      }
    }

    public static Unit FindUnit(string text)
    {
      var weight_dist = sWeight.Select(w => Measure(w, text)).OrderBy(t => t.score).First();
      var volume_dist = sVolume.Select(v => Measure(v, text)).OrderBy(t => t.score).First();
      var custom_dist = sCustom.Select(c => Measure(c, text)).OrderBy(t => t.score).First();

      var closest = new[] { weight_dist, volume_dist, custom_dist };
      return closest.OrderBy(t => t.score).First().unit;

      (Unit unit, int score) Measure<T>(T unit, string input) where T : Unit
      {
        var distance = StringDistance.Measure(unit.Display.ToLower(), input.ToLower());
        return (unit, distance);
      }
    }

    public static (string id, string typename) ToSelection(Unit unit)
    {
      return (unit.Name, unit.GetType().Name);
    }

    public static Unit FromSelection((string id, string typename) selection)
    {
      return sSelectionToUnit[selection];
    }
  }
}
