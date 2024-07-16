using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal static class Sort
  {
    public static void DoSort(string choice)
    {
      switch (choice)
      {
        case "1":
          AscSort.SortByAsc();
          break;
        case "2":
          DescSort.SortByDesc();
          break;
        default:
          throw new ArgumentException();
      }
    }
  }
}
