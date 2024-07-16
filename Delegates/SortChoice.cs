using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  public delegate void Notify(string choice);
  internal class SortChoice
  {
    static bool _ok;

    public event Notify? SortCompleted;

    public string EnterSortChoice()
    {
      _ok = false;

      while (!_ok)
      {
        Console.WriteLine("Выберите вариант сортировки:");
        Console.WriteLine("1 - от А до Я");
        Console.WriteLine("2 - от Я до А");

        var choice = Console.ReadLine();

        if(choice == "1" || choice == "2")
        {
          _ok = true;
          OnSortCompleted(choice);
          return choice;
        }
      }

      throw new Exception();
    }

    protected virtual void OnSortCompleted(string choice)
    {
      SortCompleted?.Invoke(choice);
    }
  }
}
