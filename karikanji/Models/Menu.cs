using karikanji.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public MenuType MenuType { get; set; }
        public decimal Price {get;set;}
        public virtual List<Combo> Combos { get; set; }
    }
}