using Microsoft.AspNetCore.Mvc;
using secondmvcprj.Models;
using System.Linq;
using System.Collections.Generic;
namespace secondmvcprj.Controllers{
    public class LekhanaSBAccController:Controller{
        //step no-1
        private readonly DatabaseTrainingContext db;
        public LekhanaSBAccController(DatabaseTrainingContext _db){
             db=_db;
        }
        //step -2 make changes in startup.cs
        //step-3 make changes in appsettings.json
         //public static DatabaseTrainingContext db=new DatabaseTrainingContext();
         public IActionResult getallAccs(){
          return View(db.LekhanaSbaccs.ToList());
      }
      public IActionResult Create(){
          return View();
      }
      [HttpPost]
      public IActionResult Create(LekhanaSbacc s){
          db.LekhanaSbaccs.Add(s);
          db.SaveChanges();
          return RedirectToAction("getallAccs");
      }
      public IActionResult Edit(int id){
          LekhanaSbacc l1=db.LekhanaSbaccs.Find(id);
          return View(l1);
      }
      [HttpPost]
      public IActionResult Edit(LekhanaSbacc l){
           db.LekhanaSbaccs.Update(l);
           db.SaveChanges();
           return RedirectToAction("getallAccs");
      }
      public IActionResult Delete(int id){
          LekhanaSbacc l2=db.LekhanaSbaccs.Find(id);
          return View();
      }
      [HttpPost]
      [ActionName("Delete")]
      public IActionResult DeleteConfirmed(int id){
          LekhanaSbacc l=db.LekhanaSbaccs.Find(id);
          db.LekhanaSbaccs.Remove(l);
          db.SaveChanges();
          return RedirectToAction("getallAccs");
      }
      public IActionResult Details(int id){
            LekhanaSbacc l1=db.LekhanaSbaccs.Find(id);
          return View(l1);
      }

     
    }
}