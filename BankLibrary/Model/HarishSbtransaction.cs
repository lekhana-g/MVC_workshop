using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class HarishSbtransaction
    {
        public int TId { get; set; }
        public DateTime TDate { get; set; }
        public string AccountNumber { get; set; }
        public double Amount { get; set; }
        public string TType { get; set; }
    }
}
