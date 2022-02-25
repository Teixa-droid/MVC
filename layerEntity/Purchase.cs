using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class Purchase
    {
        public int IdSale { get; set; }
        public User oUser { get; set; }
        public Provider oProvider { get; set; }

        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string TotalAmount { get; set; }
        public string DateRegister { get; set; }
    }
}
