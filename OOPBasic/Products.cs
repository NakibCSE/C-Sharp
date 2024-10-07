using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class Products
    {
        private const double DefaultDiscount = 10;
        private readonly string barcode; 
        public double Price { get; set; }
        public string Name { get; set; }

        public Products() : this(null) {
            barcode = "ABC-123";
        }
        public Products(string name) : this( 0, null)
        {
            Name = name;
        }
        public Products(double price, string name)
        {
            
            Price = price;
            Name = name;
        }


        /// <summary>
        /// Calculate discount with out a limit 
        /// </summary>
        /// <returns></returns>
        public double CalculateDiscount()
        {
            return Price * DefaultDiscount / 100;
        }

        /// <summary>
        /// Calculate Discount using a maximum allowed discount
        /// </summary>
        /// <param name="MaximumDiscount">The Maximum allowed discount value</param>
        /// <returns></returns>
        public double CalculateDiscount(int MaximumDiscount)
        {
            double discount = Price * DefaultDiscount / 100;
            return discount > MaximumDiscount
                   ? MaximumDiscount 
                   : discount;
        }
    }
}
