using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Descriptionn { get; set; }
        public Brand oBrand { get; set; }
        public Category oCategory { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageRoute { get; set; }
        public string ImageName { get; set; }
        public bool Active { get; set; }


    }
}
