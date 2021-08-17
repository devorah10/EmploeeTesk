using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmploeeTesk.Models
{
    public class Emploee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public Address adress { get; set; }
        public geo geo { get; set; }
        public string phone{ get; set; }
    }

}