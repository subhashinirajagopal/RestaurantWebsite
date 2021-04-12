using karikanji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace karikanji.ViewModels
{
    public class ComboViewModel
    {
        public int MenuId { get; set; }
        public string ComboName { get; set; }
        public List<Combo> ItemList { get; set; }
        public decimal ComboPrice { get; set; }
 
    }
}