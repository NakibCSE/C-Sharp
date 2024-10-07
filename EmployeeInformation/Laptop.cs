using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    public class Laptop
    {
        public string brandName;
        public int ram;
        public int processor;

        public string isAppropriate(int ram, int processor)
        {
            if (ram >= 8 && processor >= 5)
            {
                return "The laptop is appropriate for a programmer.";
            }
            else
            {
                return "The laptop is not appropriate for a programmer.";
            }
         }
    }
}
