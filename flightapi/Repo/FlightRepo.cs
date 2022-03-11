using flightapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace flightapi.Repo{
    public class FlightRepo : IFlightRepo<FlightD>{
        private readonly IFlightD<FlightD> f;
        public FlightRepo()
        {

        }
        public FlightRepo(IFlightD<FlightD> _f)
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
