using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Order_Monato.Flags;

namespace Order_Monato.Models.DTOs
{
    public class OfferDto
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Status status { get; set; }
    }
    
}