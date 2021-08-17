using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmploeeTesk.Models
{
    public class Address
    {
        public string street { get; set; }
        public int suite { get; set; }
        public string city { get; set; }
        public int zipcode { get; set; }
    }
}