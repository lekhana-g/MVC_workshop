﻿using System;
using System.Collections.Generic;

#nullable disable

namespace secondmvcprj.Models
{
    public partial class ManishaEmployee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string City { get; set; }
    }
}
