using Microsoft.AspNetCore.Mvc;
using finalmvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace finalmvc.Controllers{
    public class CustomerController : Controller{
         private readonly IHttpContextAccessor _hp;
     public CustomerController(IHttpContextAccessor hp){
            _hp=hp;
        }
        Random rnd=new Random();
        public IActionResult Login(){
            ViewBag.err=HttpContext.Session.GetString("check");
            return View();
        }
        
        [HttpPost]
         public IActionResult Login(Customerl c){
          if(c.customerid=="111" && c.password=="password"){
              HttpContext.Session.SetString("result",c.customerid);
              HttpContext.Session.SetInt32("s1",10);
              return RedirectToAction("GetFlights");
          }
          else{
             string err="Please check the Username and Password!!";
              HttpContext.Session.SetString("check",err);
              return RedirectToAction("Login");
          }
          return View();
        }

          public IActionResult Logout(){
             HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        string Baseurl = "https://localhost:5002/";
        string bu1="https://localhost:5001/";


        public async Task<IActionResult> GetBookings()
        {
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            List<BookF> b1 = new List<BookF>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/BookF");          
                if (Res.IsSuccessStatusCode)
                {
                    var br = Res.Content.ReadAsStringAsync().Result;
                    b1 = JsonConvert.DeserializeObject<List<BookF>>(br);
                }
              return View(b1);
            }
        }


        public async Task<IActionResult> GetFlights(){
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            List<FlightD> bf1 = new List<FlightD>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/BookF/Flight");       
                if (Res.IsSuccessStatusCode)
                {
                    var br = Res.Content.ReadAsStringAsync().Result;
                    bf1 = JsonConvert.DeserializeObject<List<FlightD>>(br);
                }
              return View(bf1);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id){
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            FlightD f=new FlightD();
            List<BookF> bf=new List<BookF>();
            TempData["fid"]=id;
            int cid=Convert.ToInt32(HttpContext.Session.GetString("result"));
            using(var c=new HttpClient()){
                 c.BaseAddress = new Uri(bu1);
                c.DefaultRequestHeaders.Clear();
                c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                using(var r=await c.GetAsync("api/Flight/"+id)){
                    string ap=await r.Content.ReadAsStringAsync();
                    f=JsonConvert.DeserializeObject<FlightD>(ap);
                }
            }
            using(var c=new HttpClient()){
                 c.BaseAddress = new Uri(Baseurl);
                c.DefaultRequestHeaders.Clear();
                c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage r=await c.GetAsync("api/Book");
                if(r.IsSuccessStatusCode){
                    var r1=r.Content.ReadAsStringAsync().Result;
                    bf=JsonConvert.DeserializeObject<List<BookF>>(r1);
                }
            }
             BookF b=new BookF();
            b.Bid=rnd.Next(100,20000);
            b.Fid=f.Fid;
            b.Cid=cid;
            b.Doj=f.Departuretime;
            ViewBag.cost=f.Costperseat;
            return View(b);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BookF bd){
            int id=Convert.ToInt32(TempData["fid"]);
               FlightD fd = new FlightD();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(bu1);
                using (var response = await httpClient.GetAsync("api/Flight/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    fd = JsonConvert.DeserializeObject<FlightD>(apiResponse);
                }
                if(bd.Count<0){
                    return RedirectToAction("CountN");
                }
           bd.Totalvalue=bd.Count*fd.Costperseat;
           if(fd.Totalcapacity>=bd.Count){
               fd.Totalcapacity=fd.Totalcapacity-bd.Count;
               StringContent content1 = new StringContent(JsonConvert.SerializeObject(fd),Encoding.UTF8,"application/json");
                        using (var response = await httpClient.PutAsync("api/Flight/" + fd.Fid, content1))
                        {
                            var apiResponse = await response.Content.ReadAsStringAsync();
                        }
           }
           else{
               string err1="Count of passengers exceeded the total flight capacity";
                 HttpContext.Session.SetString("check1",err1);
               return RedirectToAction("BookingFailed");
              } 
            }  
            using(var c=new HttpClient()){
                c.BaseAddress=new Uri(Baseurl);
            StringContent content=new StringContent(JsonConvert.SerializeObject(bd),Encoding.UTF8,"application/json");
                using (var response=await c.PostAsync("api/BookF",content))
                {
                    string apiResponse=await response.Content.ReadAsStringAsync();
                }

            }
        return RedirectToAction("getbookings");
        }


        public IActionResult BookingFailed(){
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            ViewBag.err1=HttpContext.Session.GetString("check1");
            return View();
        }


        public IActionResult CountN(){
           if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
             return View();
        }

        
    }
}