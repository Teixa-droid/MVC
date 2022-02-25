using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class Permission
    {
        public int IdPermission { get; set; }
        public Rol oRol { get; set; }
        public string NameMenu { get; set;  }
        public string DateCreation { get; set; }
    }
}
