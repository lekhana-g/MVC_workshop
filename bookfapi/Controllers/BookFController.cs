using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using bookfapi.Models;
using bookfapi.Repo;
using System.Text;
namespace bookfapi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class BookFController : ControllerBase{
        BookFRepo br=new BookFRepo();
        [HttpGet]
        public IEnumerable<BookF> Get()
        {
            return br.getBookings();
        }
        // GET api/<BookFController>/5
        [HttpGet("{id}")]
        public BookF Get(int id)
        {
            return br.getBookingById(id);
        }
        [HttpPost]
        public void Post([FromBody] BookF b)
        {
                br.AddBookingF(b);
        }
        // PUT api/<BookFController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BookF b)
        {
            br.CancelBooking(id);
            br.AddBookingF(b);
        }
        // DELETE api/<BookFController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            br.CancelBooking(id);
        }
        [HttpGet("Flight")]
        public async Task<List<FlightD>> GetFlights()
        {
            string Baseurl = "https://localhost:5001/";
            List<FlightD> FInfo = new List<FlightD>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Flight"); 
                if (Res.IsSuccessStatusCode)
                {
                    var fr = Res.Content.ReadAsStringAsync().Result;
                    FInfo = JsonConvert.DeserializeObject<List<FlightD>>(fr);
                    return FInfo;
                }
                else
                {
                    return null;
                }
            }
        }

         [HttpGet("Flight/{id}")]
        public async Task<List<FlightD>> GetFlightbyId(int id)
        {
            string Baseurl = "https://localhost:5001/";
            List<FlightD> FInfo = new List<FlightD>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Flight/" + id);
                if (Res.IsSuccessStatusCode)
                {
                    var fr = Res.Content.ReadAsStringAsync().Result;
                    FInfo = JsonConvert.DeserializeObject<List<FlightD>>(fr);
                    return FInfo;
                }
                else
                {
                    return null;
                }
            }
        }


        
    }
}