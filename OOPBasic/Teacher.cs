using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace OOPBasic 
{ 
    public class Teacher : User
    {
        internal double Salary {  get; set; }
        public Teacher(string userName, string password) : base(userName, password)
        {
            id = "TE-" + userName.Substring(0, 3);
        }
        internal void CalculateSalary()
        {
            Salary = 20000;
        }
    }
}
