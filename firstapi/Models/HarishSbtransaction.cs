﻿using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class HarishSbtransaction
    {
        public int TId { get; set; }
        public DateTime TDate { get; set; }
        public int AccountNumber { get; set; }
        public int Amount { get; set; }
        public string TType { get; set; }
    }
}
