using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookfapi.Models{
    public class FlightD{
        public int Fid { get; set; }
        public string Fname { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departuretime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int Totalcapacity { get; set; }
        public int Costperseat { get; set; }
    }
}