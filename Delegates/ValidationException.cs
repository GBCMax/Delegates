using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal class ValidationException : ArgumentException
  {
    public ValidationException(string lastName) : base()
    {
      Console.WriteLine($"Фамилия: {lastName} содержит посторонние символы");
    }
  }
}
