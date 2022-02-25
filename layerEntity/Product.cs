using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Code { get; set; }
        public string Namee { get; set; }
        public string Descriptionn { get; set; }
        public Category IdCategory { get; set; }
        public int Stock { get; set; }
        public decimal PricePurchase { get; set; }
        public decimal PriceSale { get; set; }
        public bool Statuss { get; set; }
        public string DateRegister { get; set; }

    }
}
