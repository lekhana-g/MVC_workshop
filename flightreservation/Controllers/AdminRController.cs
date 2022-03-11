using Microsoft.AspNetCore.Mvc;
using flightreservation.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Web;
using System;
namespace flightreservation.Controllers{
    public class AdminRController:Controller{
             private readonly DatabaseTrainingContext db;
             public AdminRController(DatabaseTrainingContext _db){
             db=_db;
             }
             public IActionResult getallRoutes(){
                  if(HttpContext.Session.GetInt32("s1")==null){
               return RedirectToAction("login","adminf");
           }
          return View(db.RouteDetails.ToList());
          }
          public IActionResult Create(){
              if(HttpContext.Session.GetInt32("s1")==null){
               return RedirectToAction("login","adminf");
           }
              return View();
          }
          [HttpPost]
          public IActionResult Create(RouteDetail r){
              db.RouteDetails.Add(r);
              db.SaveChanges();
              return RedirectToAction("getallRoutes");
          }
          public IActionResult Edit(int id){
              RouteDetail r=db.RouteDetails.Find(id);
              return View(r);
          }

          [HttpPost]
          public IActionResult Edit(RouteDetail r){
              db.RouteDetails.Update(r);
              db.SaveChanges();
              return RedirectToAction("getallRoutes");
          }
          public IActionResult Delete(int id){
              RouteDetail r=db.RouteDetails.Find(id);
              return View(r);
          }
          [HttpPost]
          [ActionName("Delete")]
          public IActionResult DeleteConfirmed(int id){
              RouteDetail r=db.RouteDetails.Find(id);
             db.RouteDetails.Remove(r);
             db.SaveChanges();
             return RedirectToAction("getallRoutes");
          }

    }
}