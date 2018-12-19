using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace NutritionCalc
{
  public partial class GroupedItemView : DevExpress.XtraEditors.XtraUserControl
  {
    public GroupedItemView()
    {
      InitializeComponent();
    }

    public event EventHandler<GroupedItemViewEventArgs> ItemClicked;

    private IEnumerable<NavBarGroup> Groups
    {
      get
      {
        foreach (var group in navBarControl1.Groups.OfType<NavBarGroup>())
        {
          yield return group;
        }

        foreach (var group in navBarControl2.Groups.OfType<NavBarGroup>())
        {
          yield return group;
        }
      }
    }

    private NavBarItem CreateItem<TItem>(TItem item)
      where TItem : IHaveName
    {
      return new NavBarItem(item.Name) { Tag = item };
    }

    private bool TryFindGroup<TCategory>(TCategory key, out NavBarGroup group)
    {
      var table = Groups
        .Select(g => pack(g))
        .Where(i => i.valid)
        .ToDictionary(k => k.c, v => v.g);

      return table.TryGetValue(key, out group);

      (NavBarGroup g, bool valid, TCategory c) pack(NavBarGroup value)
      {
        return (value.Tag is TCategory c)
          ? (value, true, c)
          : (value, false, default(TCategory));
      }
    }

    private bool TryFindItem<TItem>(TItem key, out NavBarItemLink link)
    {
      link = Groups
        .SelectMany(g => g.ItemLinks)
        .SingleOrDefault(l => ReferenceEquals(l.Item.Tag, key));
      return (link != null);
    }

    private void AddItemSorted<TItem>(TItem item, NavBarGroup group)
      where TItem : IHaveName
    {
      var value = CreateItem(item);

      int i = 0;
      for (; i < group.ItemLinks.Count; ++i)
      {
        var link = group.ItemLinks[i];
        if (string.CompareOrdinal(item.Name, link.Caption) < 0)
        {
          // the item should be before this link
          group.ItemLinks.Insert(i, value);
          return;
        }
      }

      // if we get here, just add the item
      group.ItemLinks.Add(value);
    }

    protected virtual void OnItemClicked(GroupedItemViewEventArgs e)
    {
      ItemClicked?.Invoke(this, e);
    }

    public IEnumerable<T> OfType<T>()
    {
      return Groups.SelectMany(g => g.ItemLinks).Select(i => i.Item.Tag).OfType<T>();
    }

    public void Populate<TCategory, TItem>(IEnumerable<TCategory> categories, IEnumerable<TItem> items, Func<TItem, TCategory> getCategory)
      where TItem : IHaveName
    {
      var arrCategories = categories
        .Select(c => (value: c, text: $"{c}"))
        .OrderBy(t => t.text)
        .Select(t => t.value)
        .ToArray();

      var itemLookUp = items.ToLookup(getCategory);

      var right = arrCategories.Length / 2;
      var left = arrCategories.Length - right;

      var bar = navBarControl1;
      for (int i = 0; i < arrCategories.Length; ++i)
      {
        var category = arrCategories[i];
        var navGroup = new NavBarGroup($"{category}");
        navGroup.Tag = category;

        bar.Groups.Add(navGroup);
        if ((i + 1) == left)
        {
          bar = navBarControl2;
        }

        foreach (var item in itemLookUp[category].OrderBy(v => v.Name))
        {
          navGroup.ItemLinks.Add(CreateItem(item));
        }
      }
    }

    public void AddItem<TCategory, TItem>(TItem item, Func<TItem, TCategory> getCategory)
      where TItem : IHaveName
    {
      if (TryFindGroup(getCategory(item), out NavBarGroup group))
      {
        AddItemSorted(item, group);
      }
    }

    public void UpdateItem<TCategory, TItem>(TItem item, Func<TItem, TCategory> getCategory)
      where TItem : IHaveName
    {
      if (TryFindGroup(getCategory(item), out NavBarGroup desired) && TryFindItem(item, out NavBarItemLink link))
      {
        // remove, then add it back
        var current = link.Group;
        current.ItemLinks.Remove(link);
        AddItemSorted(item, desired);
      }
    }

    public void RemoveItem<TCategory, TItem>(TItem item, Func<TItem, TCategory> getCategory)
      where TItem : IHaveName
    {
      if (TryFindGroup(getCategory(item), out NavBarGroup desired) && TryFindItem(item, out NavBarItemLink link))
      {
        var current = link.Group;
        current.ItemLinks.Remove(link);
      }
    }

    private void navBarControl_LinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var link = e.Link;
      OnItemClicked(new GroupedItemViewEventArgs(link.Group.Tag, link.Item.Tag));
    }
  }
}
