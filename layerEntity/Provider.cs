using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layerEntity
{
    public class Provider
    {
        public int IdProvider { get; set; }
        public string Document { get; set; }
        public string SocialReason { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Statuss { get; set; }
        public string DateRegister { get; set; }
    }
}
