using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilecare.Core.Utils
{
    public class PhoneValidator
    {
        public static bool IsValidIndianMobile(string input) => !string.IsNullOrWhiteSpace(input) && input.Length == 10 && input.All(char.IsDigit);
    }
}
