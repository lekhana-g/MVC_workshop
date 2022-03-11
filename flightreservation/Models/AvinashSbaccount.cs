using System;
using System.Collections.Generic;

#nullable disable

namespace flightreservation.Models
{
    public partial class AvinashSbaccount
    {
        public string CustomerName { get; set; }
        public decimal AccountNumber { get; set; }
        public string Address { get; set; }
        public decimal? CurrentBalance { get; set; }
    }
}
