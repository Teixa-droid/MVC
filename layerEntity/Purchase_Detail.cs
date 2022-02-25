using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    class Purchase_Detail
    {
        public int IdPurchaseDetail { get; set; }

        public Product oProduct { get; set; }

        public decimal PricePurchase { get; set; }

        public decimal PriceSale { get; set; }

        public int Quantity { get; set; }

        public decimal SubTotal { get; set; }
        public string DateRegister { get; set; }

    }
}
