using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSMART_03
{
    internal class CartClass
    {
        public int idproduct { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice{ get; set; }
        public int ProductStock { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string ImageNames { get; set; }
        public int Subtotal { get { return Convert.ToInt32(ProductPrice * Quantity); } }

    }
}
