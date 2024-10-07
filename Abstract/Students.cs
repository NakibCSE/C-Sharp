using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Students : User
    {
        public Students(string userName, string password) : base(userName, password)
        {
            id = "ST-" + userName.Substring(0, 3);
        }
        public override void CreateID()
        {
            id = "ST-" + new IDGenerator().Generate();
        }
    }
}
