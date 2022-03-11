using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class AjaySbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public double? CurrentBalance { get; set; }
    }
}
