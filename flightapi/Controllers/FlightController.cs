using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightapi.Repo;
using flightapi.Models;
using flightapi.Service;
namespace flightapi
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService<FlightD> f1;
        public FlightController(IFlightService<FlightD> service)
        {
            f1 = service;
        }
        [HttpGet]
        public IEnumerable<FlightD> Get()
        {
            return f1.GetFlights();
        }
        // GET api/<FlightController>/5
        [HttpGet("{id}")]
        public FlightD Get(int id)
        {
            return f1.GetFlightById(id);
        }
        // POST api/<FlightController>
        [HttpPost]
        public void Post([FromBody] FlightD f)
        {
            f1.AddFlight(f);
        }
        // PUT api/<FlightController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FlightD f)
        {
            f1.DeleteFlight(f.Fid);
            f1.AddFlight(f);
        }
        // DELETE api/<FlightController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            f1.DeleteFlight(id);
        }
    }
}
