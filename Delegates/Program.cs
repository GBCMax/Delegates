using Delegates;

internal class Program
{
  private static SortChoice _sortChoice = new();
  private static void Main(string[] args)
  {
    try
    {
      DataEntry.EnterData();

      Console.WriteLine("Список до сортировки:");

      WriteList();

      _sortChoice.SortCompleted += Sort.DoSort;

      var choice = _sortChoice.EnterSortChoice();

      Console.WriteLine("Список после сортировки:");

      WriteList();
    }
    catch (ValidationException)
    {
      Console.WriteLine("Введите корректные данные");
    }
    catch (ArgumentNullException)
    {
      Console.WriteLine("Вы не ввели значение");
    }
    catch (IndexOutOfRangeException)
    {
      Console.WriteLine("Индекс вышел за границы массива");
    }
    catch (ArgumentException)
    {
      Console.WriteLine("Аргумент находится вне диапазона допустимых значений");
    }
    catch (Exception)
    {
      Console.WriteLine("Непредвиденная ошибка");
    }
  }

  internal static void WriteList()
  {
    foreach(var person in DataEntry.ListOfPeople)
    {
      Console.WriteLine(person);
    }
  }
}