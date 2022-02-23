using System;
using System.Collections.Generic;
using System.Text;

namespace Ders8
{
    public class Product
    {
        public int ProId { get; set; }
        public string ProName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return ProId + " " + ProName + " " + Price;
        }
    }
}
