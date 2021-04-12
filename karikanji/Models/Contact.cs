using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace karikanji.Models
{
    public class Contact
    {
        public int ContactId { get; set; }        
        public string AddressLine1 {get;set;}
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string Timings { get; set; }
        public string PhoneNumber {get;set;}
        public string Email {get;set;}
    }
}