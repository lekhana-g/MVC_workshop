using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightapi.Models
{
   public interface IFlightD<FlightD>
    {
        public void AddFlight(FlightD f);
        public void DeleteFlight(int id);
        public List<FlightD> GetFlights();
        public FlightD GetFlightById(int id);
    }
}
