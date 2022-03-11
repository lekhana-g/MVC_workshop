using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartAPI.Models
{
    public class Product
    {
            public int Pid { get; set; }
            public string Pname { get; set; }
            public int Qty { get; set; }
            public int Price { get; set; }
    }
}
