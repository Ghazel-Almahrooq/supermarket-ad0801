using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket_ad0801.entities
{
   public  class Sales
    {
        public int Sid { get; set; }
        public string  Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
