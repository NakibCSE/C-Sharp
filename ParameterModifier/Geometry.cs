using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Geometry
    {
        public double CalculateAverage(params double[] items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum/items.Length;
        }
        public void Calculate(ref int x)
        {
            Console.WriteLine(x);
            x = 9; 
        }
        public void Calculate2(in int x)
        {
            Console.WriteLine(x);
        }
        public void Calculate3(out int x, out int y, out int z)
        {
            x = 10;
            y = 11;
            z = 12;
        }

    }
}
