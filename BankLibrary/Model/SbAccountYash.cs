using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Model
{
    public partial class SbAccountYash
    {
        public SbAccountYash()
        {
            SbTransactionYashes = new HashSet<SbTransactionYash>();
        }

        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public decimal CurrentBalance { get; set; }

        public virtual ICollection<SbTransactionYash> SbTransactionYashes { get; set; }
    }
}
