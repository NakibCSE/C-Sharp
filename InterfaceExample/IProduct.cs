using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IProduct
    {
        double CalculateServiceCharge();
        double CalculateDiscount();
        public double GetDefaultDiscount(int max)
        {
            if (max < 10)
                return max;
            else
                return 10; 
        }

    }
}
