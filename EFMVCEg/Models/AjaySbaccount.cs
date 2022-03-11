using System;
using System.Collections.Generic;

#nullable disable

namespace EFMVCEg.Models
{
    public partial class AjaySbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public double? CurrentBalance { get; set; }
        public double? MaxBalance { get; set; }
    }
}
