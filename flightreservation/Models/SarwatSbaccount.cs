using System;
using System.Collections.Generic;

#nullable disable

namespace flightreservation.Models
{
    public partial class SarwatSbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public decimal? CustomerBalance { get; set; }
    }
}
