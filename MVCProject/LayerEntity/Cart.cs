using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{
    public class Cart
    {
        public int IdCart { get; set; }
        public Customer oCustomer { get; set; }
        public Product oProduct { get; set; }
        public int Quantity { get; set; }
    }
}
