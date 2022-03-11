using System;
using System.Collections.Generic;

#nullable disable

namespace flightreservation.Models
{
    public partial class RaviSbaccount
    {
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public double? CurrentBalance { get; set; }
    }
}
