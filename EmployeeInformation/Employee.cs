using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EmployeeInformation
{
    public class Employee
    {
        public string id;
        public string name;
        public double salaryAmount;

        public string GetInfoAboutEmployee()
        {
            return name + " is very punctual.";
        }
    }
}
