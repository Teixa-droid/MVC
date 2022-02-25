using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{
    public class Sale
    {
        public int IdSale { get; set; }
        public int IdCustomer { get; set; }
        public int TotalProduct { get; set; }
        public decimal AmountTotal { get; set; }
        public string Contact { get; set; }
        public string IdDistrict { get; set; }
        public string Phone { get; set; }
        public string Addresss { get; set; }
        public string SoldTo { get; set; }
        public string IdTransaction { get; set; }
        public List<DetailSale> oDetailSale { get; set; }

    }
}
