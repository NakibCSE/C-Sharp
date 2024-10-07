using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class IDGenerator
    {
        public string Generate()
        {
            return new Random(DateTime.Now.Microsecond).Next(300, 999).ToString();
        }
    }
}
