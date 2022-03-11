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
    public class AdminController : Controller{
    //     private readonly IHttpContextAccessor _hp;
    //  public AdminController(IHttpContextAccessor hp){
    //         _hp=hp;
    //     }
        public IActionResult Login(){
            ViewBag.err=HttpContext.Session.GetString("check");
            return View();
        }
        [HttpPost]
        public IActionResult Login(User f){
          if(f.username=="admin" && f.pass=="password"){
              //HttpContext.Session.SetString("result",f.username);
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
            return RedirectToAction("login");
        }
        string Baseurl = "https://localhost:5002/";
        public async Task<IActionResult> GetFlights()
        {
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            List<FlightD> f1 = new List<FlightD>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/BookF/Flight");           
                if (Res.IsSuccessStatusCode)
                {
                    var fr = Res.Content.ReadAsStringAsync().Result;
                    f1= JsonConvert.DeserializeObject<List<FlightD>>(fr);
                }
              return View(f1);
            }
        }


        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
            TempData["Prid"] = id;
            FlightD f = new FlightD();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Flight/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    f = JsonConvert.DeserializeObject<FlightD>(apiResponse);
                }
            }
            return View(f);
        }
        [HttpPost]
        public async Task<ActionResult> Delete(FlightD f)
        {
            //Deleting a product
            int prid = Convert.ToInt32(TempData["Prid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/Flight/" + prid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("GetFlights");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id){
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
             TempData["fid"]=id;
            FlightD f=new FlightD();
            using(var c=new HttpClient()){
                using(var r=await c.GetAsync("https://localhost:5001/api/Flight/"+id)){
                    string apiResponse=await r.Content.ReadAsStringAsync();
                    f=JsonConvert.DeserializeObject<FlightD>(apiResponse);
                }
            }
            return View(f);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(FlightD f){
            FlightD f1=new FlightD();
            using(var c=new HttpClient()){

                int id=Convert.ToInt32(TempData["fid"]);
                 StringContent content = new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json");
                 if(f.Totalcapacity<0||f.Costperseat<0||f.Fid<0){
                 string err4="Input cannot be negtaive";
                 HttpContext.Session.SetString("c2",err4);
                  return RedirectToAction("create");
                 }
                 else{
                 using(var r=await c.PutAsync("https://localhost:5001/api/Flight/" +id,content)){
                     string apiResponse=await r.Content.ReadAsStringAsync();
                     f1=JsonConvert.DeserializeObject<FlightD>(apiResponse);
                 }
            }
            }
            return RedirectToAction("getflights");
        } 


         public IActionResult Create()
        {
            if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
             ViewBag.err3=HttpContext.Session.GetString("c1");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(FlightD f)
        {
            if(ModelState.IsValid){
            FlightD Fobj = new FlightD();
          //  HttpClient obj = new HttpClient();
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content = new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json");
                 if(f.Totalcapacity<0||f.Costperseat<0||f.Fid<0){
                 string err3="Input cannot be negtaive";
              HttpContext.Session.SetString("c1",err3);
              return RedirectToAction("create");
                 }
                 else{
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/Flight", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Fobj = JsonConvert.DeserializeObject<FlightD>(apiResponse);
                }
            }
            }
            }
            return RedirectToAction("GetFlights");
        }

    }
}