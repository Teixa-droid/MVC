using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class Sale
    {
        public int IdSale { get; set; }
        public User oUser { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentCustomer { get; set; }
        public string CustomerName { get; set; }
        public decimal AmountPayment { get; set; }
        public decimal AmountChange { get; set; }
        public decimal TotalAmount { get; set; }
        public List<Sale_Detail> oSaleDetail { get; set; }
        public string DateRegister { get; set; }
    }
}
