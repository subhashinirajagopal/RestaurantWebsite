using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karikanji.Models
{
    public class About
    {
        public int AboutId { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}