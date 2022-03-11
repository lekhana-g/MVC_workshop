using Microsoft.AspNetCore.Mvc;
using flightreservation.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
namespace flightreservation.Controllers{
    public class AdminFController:Controller{
        private IWebHostEnvironment webHostEnvironment;
        private readonly DatabaseTrainingContext db;
        private readonly IHttpContextAccessor _httpContextAccessor; 
        public AdminFController(IHttpContextAccessor httpContextAccessor,DatabaseTrainingContext _db,IWebHostEnvironment _webHostEnvironment){
            _httpContextAccessor=httpContextAccessor;db=_db;webHostEnvironment=_webHostEnvironment;
        }
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public IActionResult Login(User f){
          if(f.username=="admin" && f.pass=="password"){
              HttpContext.Session.SetString("result",f.username);
              HttpContext.Session.SetInt32("s1",10);
              return RedirectToAction("getallFlights");
          }
          else
          return View();
        }
        public IActionResult Logout(){
             HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
       
        public IActionResult getallFlights(){
             if(HttpContext.Session.GetInt32("s1")==null){
                 return RedirectToAction("login");
             }
          return View(db.FlightDetails.ToList());
      }
       public IActionResult Create(){
           if(HttpContext.Session.GetInt32("s1")==null){
               return RedirectToAction("login");
           }
          return View();
      }
      [HttpPost]
      public IActionResult Create(fdi f){
         using(var db=new DatabaseTrainingContext()){
              string fname=null;
              if(f.Imagepath!=null){
                  string up=Path.Combine(webHostEnvironment.WebRootPath,"Images");
                  fname=f.Imagepath.FileName;
                  string fp=Path.Combine(up,fname);
                  using(var fileStream=new FileStream(fp,FileMode.Create)){
                      f.Imagepath.CopyTo(fileStream);
                  }
                  FlightDetail f1=new FlightDetail();
                  f1.Flightid=f.Flightid;
                  f1.Flightname=f.Flightname;
                  f1.Source=f.Source;
                  f1.Destination=f.Destination;
                  f1.Departuretime=f.Departuretime;
                  f1.Arrivaltime=f.Arrivaltime;
                  f1.Totalcapacity=f.Totalcapacity;
                  f1.Costperseat=f.Costperseat;
                  f1.Imagepath="~/images/"+fname;
                  db.FlightDetails.Add(f1);
                  db.SaveChanges();
                  return RedirectToAction("getallFlights");
              }
              else {

              }
              
         }
         return RedirectToAction("getallFlights");
        //   db.FlightDetails.Add(f);
        //   db.SaveChanges();
        //   return RedirectToAction("getallFlights");
      }
       public IActionResult Edit(int id){
            if(HttpContext.Session.GetInt32("s1")==null){
               return RedirectToAction("login");
           }
           FlightDetail f=db.FlightDetails.Find(id);
           return View(f);
      }
      [HttpPost]
      public IActionResult Edit(FlightDetail f){
           db.FlightDetails.Update(f);
           db.SaveChanges();
           return RedirectToAction("getallFlights");
      }
       public IActionResult Delete(int id){
            if(HttpContext.Session.GetInt32("s1")==null){
               return RedirectToAction("login");
           }
          FlightDetail l2=db.FlightDetails.Find(id);
          return View();
      }
      [HttpPost]
      [ActionName("Delete")]
      public IActionResult DeleteConfirmed(int id){
          FlightDetail f=db.FlightDetails.Find(id);
          db.FlightDetails.Remove(f);
          db.SaveChanges();
          return RedirectToAction("getallFlights");
      }  
    }
}