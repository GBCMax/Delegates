using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal static class DataEntry
  {
    static bool _ok;
    static readonly int _count = 5;
    public static List<string> ListOfPeople = [];

    public static void EnterData()
    {
      for (int i = 0; i < _count; i++)
      {
        _ok = false;

        while (!_ok)
        {
          Console.Write("Введите фамилию: ");

          var lastName = Console.ReadLine();

          _ok = Validator.Validate(lastName);

          if (_ok)
          {
            ListOfPeople.Add(lastName);
          }
          else
          {
            Console.WriteLine("Введите корректные данные");
          }
        }
      }
    }
  }
}
