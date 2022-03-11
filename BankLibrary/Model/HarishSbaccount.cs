using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class HarishSbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int CurrentBalance { get; set; }
    }
}
