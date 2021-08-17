using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmploeeTesk.Models
{
    public class Todo
    {
        public int id { get; set; }
        public int Userid { get; set; }
        public string title { get; set; }
        public bool complated { get; set; }

    }
}