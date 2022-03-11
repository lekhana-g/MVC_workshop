using System;
using System.Collections.Generic;

#nullable disable

namespace flightreservation.Models
{
    public partial class SundaramSbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CurrentBalance { get; set; }
    }
}
