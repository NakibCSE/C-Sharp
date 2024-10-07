using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product
    {
         public double Price { get; set; } 
        
         public Product() {
            Name = string.Empty;
            Price = 0;
          }
         public double CalculateDiscountedPrice(double discount)
        {
            return Price * discount / 100;
        }
    }
}
