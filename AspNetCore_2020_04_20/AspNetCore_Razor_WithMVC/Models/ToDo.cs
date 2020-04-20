using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Razor_WithMVC.Models
{
    public class ToDo
    {
        public string Title { get; set; }

        public string Beschreibung { get; set; }

        public DateTime BisWann { get; set; }

        public bool IstAktiv { get; set; }
    }
}
