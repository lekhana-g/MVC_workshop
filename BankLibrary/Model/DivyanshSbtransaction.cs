using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class DivyanshSbtransaction
    {
        public int Transactionid { get; set; }
        public DateTime? Transactiondate { get; set; }
        public int Accountnumber { get; set; }
        public double Amount { get; set; }
        public string Transactiontype { get; set; }
    }
}
