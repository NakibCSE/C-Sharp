using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace AbstractClass
{ 
    public class Teacher : User
    {
        internal double Salary {  get; set; }
        public Teacher(string userName, string password) : base(userName, password)
        {
            
        }
        internal void CalculateSalary()
        {
            Salary = 20000;
        }
        public override void CreateID()
        {
            id = "TE-" + UserName.Substring(0, 3);
        }
    }
}
