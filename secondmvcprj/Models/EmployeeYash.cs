using System;
using System.Collections.Generic;

#nullable disable

namespace secondmvcprj.Models
{
    public partial class EmployeeYash
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
