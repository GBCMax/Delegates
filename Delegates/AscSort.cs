using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal static class AscSort
  {
    public static List<string> SortByAsc()
    {
      DataEntry.ListOfPeople.Sort();

      return DataEntry.ListOfPeople;
    }
  }
}
