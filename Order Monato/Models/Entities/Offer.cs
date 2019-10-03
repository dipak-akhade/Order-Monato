using Order_Monato.Flags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Monato.Models.Entities
{
    public class Offer
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Status status { get; set; }
    }
}