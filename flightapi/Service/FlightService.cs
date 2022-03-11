using flightapi.Models;
using flightapi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightapi.Service
{
    public class FlightService : IFlightService<FlightD>
    {
        private readonly IFlightRepo<FlightD> f;
        public FlightService()
        {

        }
        
        public FlightService(IFlightRepo<FlightD> _f)
        {
            f = _f;
        }
        public void AddFlight(FlightD f)
        {
            f.AddFlight(f);   
        }

        public void DeleteFlight(int id)
        {
            f.DeleteFlight(id);
        }

        public FlightD GetFlightById(int id)
        {
            return f.GetFlightById(id);
        }

        public List<FlightD> GetFlights()
        {
           return f.GetFlights();
        }
    }
}
