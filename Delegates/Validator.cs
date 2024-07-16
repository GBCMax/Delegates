using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  internal class Validator
  {
    public static bool Validate(string? el)
    {
      if(string.IsNullOrWhiteSpace(el)) return false;

      if (!el.Any(c => char.IsLetter(c))) throw new ValidationException(el);

      return true;
    }
  }
}
