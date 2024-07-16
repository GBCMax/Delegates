using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal static class DescSort
  {
    public static List<string> SortByDesc()
    {
      DataEntry.ListOfPeople.Sort();

      DataEntry.ListOfPeople.Reverse();

      return DataEntry.ListOfPeople;
    }
  }
}
