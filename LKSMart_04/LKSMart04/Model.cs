using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSMart04
{
    internal class Model
    {
        public int ID { get; set; }
        public string ProductName  { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public string NameImage { get; set; }
        public int TotalPrice { get { return ProductPrice * Quantity; } }
        public string Categoryname { get; set; }
    }
}
