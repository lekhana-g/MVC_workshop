﻿using System;
using System.Collections.Generic;

#nullable disable

namespace flightreservation.Models
{
    public partial class SbtransactionSankalp
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
