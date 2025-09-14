using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilecare.Core.Model
{
    public class LoginResult
    {
        public string Token { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
