using Microsoft.AspNetCore.Mvc;
using EFMVCEg.Models;
using System.Linq;
using System.Collections.Generic;
namespace EFMVCEg.Controllers{
   public class EmployeeController:Controller{
       public static DatabaseTrainingContext db=new DatabaseTrainingContext();
      public IActionResult getallEmps(){
          return View(db.Employees.ToList());
      }
      public IActionResult Create(){
          return View();
                }
                public IActionResult Create(Employee e){
                    db.Employees.Add(e);
                    db.SaveChanges();
                    return RedirectToAction("getAllEmps");
                }
   }
}