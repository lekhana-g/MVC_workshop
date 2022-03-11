using Microsoft.AspNetCore.Mvc;
using flightreservation.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Web;
using System;
//using System.Web.ApplicationServices;
namespace flightreservation.Controllers{
    public class CustomerFController:Controller{
         private readonly DatabaseTrainingContext db;
             public CustomerFController(DatabaseTrainingContext _db){
             db=_db;
            }
            public IActionResult Index(){
                return View();
            }
            public  IActionResult Register(){
                return View();
            }
            [HttpPost]
            public IActionResult Register(CustomerDetail cd){
                if(ModelState.IsValid){
                db.CustomerDetails.Add(cd);
                db.SaveChanges();
                return RedirectToAction("Index");
                }
                else{
                    ModelState.AddModelError("","....");
            }
            return View(cd);
            }
            public IActionResult Login(){
                return View();
            }
            [HttpPost]
            public IActionResult Login(CustomerDetail cd){
              if(ModelState.IsValid){
                  using(DatabaseTrainingContext db=new DatabaseTrainingContext()){
                      var obj=db.CustomerDetails.Where(u=>u.Customername.Equals(cd.Customername) && u.Password.Equals(cd.Password)).FirstOrDefault();
                      if(obj!=null){
                          ViewBag.result=obj.Customername;
                          HttpContext.Session.SetString("result",obj.Customername);
                          HttpContext.Session.SetInt32("s2",14);
                          //FormsAuthentication.SetAuthCookie(cd.Customername,false);
                          return RedirectToAction("getallFlights");
                      }
                  }
              }
              else{
                  ModelState.AddModelError("","Invalid username,invalid password");
              }
              return View(cd);
            }
            [Route("GetFlightDetails")]
         public IActionResult getallFlights(){
              if(HttpContext.Session.GetInt32("s2")==null){
               return RedirectToAction("login");
              }
             ViewBag.result=HttpContext.Session.GetString("result");
             return View(db.FlightDetails.ToList());
             }
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
        
        public IActionResult Edit(int id){
             if(HttpContext.Session.GetInt32("s2")==null){
               return RedirectToAction("login");
           }
            BookingDetail bd=new BookingDetail();
            bd.Bookingid=db.BookingDetails.Max(x=>x.Bookingid)+1;
            bd.Routeid=db.RouteDetails.Where(x=>x.Flightid==id).Select(x=>x).SingleOrDefault().Routeid;
            bd.Flightid=id;
            bd.Doj=db.FlightDetails.Where(y=>y.Flightid==id).Select(y=>y).SingleOrDefault().Departuretime;
            return View(bd);
        }
        
        [HttpPost]
        public IActionResult Edit(BookingDetail bd){
            int? id=bd.Flightid;
            double? cost=db.FlightDetails.Where(x=>x.Flightid==id).Select(x=>x).SingleOrDefault().Costperseat;
            bd.Totalvalue=cost*bd.Numberofpassengers;
            FlightDetail f=db.FlightDetails.Find(id);
            if(f.Totalcapacity>=bd.Numberofpassengers){
                f.Totalcapacity=f.Totalcapacity-bd.Numberofpassengers;
                db.FlightDetails.Update(f);
                db.BookingDetails.Add(bd);
                db.SaveChanges();
                return RedirectToAction("Bookingdetails");
            }
            else{
                return RedirectToAction("Unsuccessfulbooking");
            }
        }
      public IActionResult Bookingdetails(){
           if(HttpContext.Session.GetInt32("s2")==null){
               return RedirectToAction("login");
           }
        //   BookingDetail bd=db.BookingDetails.Find(id);
          return View();
      }
      public IActionResult Unsuccessfulbooking(){
           if(HttpContext.Session.GetInt32("s2")==null){
               return RedirectToAction("login");
           }
          return View();
      }
      public IActionResult getAllBookings(){
          if(HttpContext.Session.GetInt32("s2")==null){
               return RedirectToAction("login");
           }
           List<BookingDetail> b1=new List<BookingDetail>();
           foreach(var bd11 in db.BookingDetails){
               if(bd11.Customerid==444){
                   b1.Add(bd11);
               }
           }

         return View(b1);
      }
    }
}