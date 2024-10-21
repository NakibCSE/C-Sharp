using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Coordinate<T, V>
    {
        public T X {  get; set; }
        public V Y { get; set; }

    }
}
