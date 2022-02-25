using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class User
    {
        public int IdUser { get; set; }
        public string Document { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Key { get; set; }
        public Rol oRol { get; set; }
        public bool Status { get; set; }
        public string DateRegister { get; set; }


    }
}
