using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public class Geometry
    {
        private static readonly double _pi;
        public static double PI
        {
            get { return _pi; } 
        }
        static Geometry()
        {
            _pi = 3.1416;
        }
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius; 
        }
        public static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
