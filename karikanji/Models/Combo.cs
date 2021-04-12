using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace karikanji.Models
{
    public class Combo
    {
        public int ComboId { get; set; }
        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }

        public string Item { get; set; }
    }
}