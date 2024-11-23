using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class Product : ICloneable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsDefault { get; set; }
        public object Clone()
        {
            return new Product
            {
                Name = Name,
                Description = Description,
                Price = Price,
                IsDefault = IsDefault
            };
        }
    }
}
