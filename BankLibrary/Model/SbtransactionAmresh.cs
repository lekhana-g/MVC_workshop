using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class SbtransactionAmresh
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
    }
}
