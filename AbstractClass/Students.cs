using OOPBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Students : User
    {
        public Students(string userName, string password) : base(userName, password)
        {
            
        }
        public override void CreateID()
        {
            id = "ST-" + id;
        }
    }
}
