using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{
    public class DetailSale
    {
        public int IdDetailSale { get; set; }
        public int IdSale { get; set; }
        public Product oProduct { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }
    }
}
