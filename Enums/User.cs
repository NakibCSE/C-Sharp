using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class User
    {
        public string UserName {  get; set; }
        public string Password { get; set; }

        public AccountType AccoutType { get; set; }
    }
}
