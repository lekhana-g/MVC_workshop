using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstapi.Models;
using Microsoft.Extensions.Logging;

namespace firstapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        //when we dont have views,we have to return it in the form of json files
        [HttpGet]
        [Route("Allflights")]
        public ActionResult <List<FlightDetail>> getAllFlights(){
            using(var db=new DatabaseTrainingContext()){
                var f=db.FlightDetails.ToList();
                return Ok(f);
            }
        }
        //async- till the api gives the response,client will not be waiting for it
        [HttpGet]
        [Route("details/{id}")]
        public async Task<ActionResult<FlightDetail>> getFlightDetails(int id){
            using(var db=new DatabaseTrainingContext()){
                FlightDetail f1=await db.FlightDetails.FindAsync(id);
                return Ok(f1);
            }
        }

        [HttpPost]
        [Route("AddFlight")]
        //here we dont give FlightDetail,because its an action and we dont need to fetch any result
        //status codes :- 200 series(success codes),400 series(error in req),500 series(error in server)
        public async Task<ActionResult> AddFlights(FlightDetail f){
            using(var db=new DatabaseTrainingContext()){
                db.FlightDetails.Add(f);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpPut]
        [Route("EditFlights")]
        public async Task<ActionResult> ModifyFlight(int id,FlightDetail f){
            using(var db=new DatabaseTrainingContext()){
                db.FlightDetails.Update(f);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteFlight")]
        public async Task<ActionResult> RemoveFlight(int id){
            using(var db=new DatabaseTrainingContext()){
                FlightDetail f=db.FlightDetails.Find(id);
                db.FlightDetails.Remove(f);
                await db.SaveChangesAsync();
                return Ok();
            }
        }


    }
}