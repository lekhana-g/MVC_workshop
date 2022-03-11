using Microsoft.AspNetCore.Mvc;
using firstmvcproj.Models;
using System.Collections.Generic;
using System.Linq;
namespace firstmvcproj.Controllers{
    public class EmployeeController:Controller{
        //Emp obj=new Emp();
        public static List<Emp> emps=Emp.GetEmployees();

        public IActionResult Sample(){
            ViewData["name"]="Lekhana";
            ViewBag.CollegeName="Vit";
            return View();
        }
        public IActionResult GetEmployeeDetails(){
            // obj.eid=1;
            // obj.name="Lekhana";
            // obj.salary=30000;

            // obj1.eid=2;
            // obj1.name="phani";
            // obj1.salary=40000;
            // emps.Add(obj);
            // emps.Add(obj1);

            //using models to intialise
            //emps=Emp.GetEmployees();
            return View(emps);
        }
        public IActionResult AddNewEmployee(){
            return View();

        }
        [HttpPost] 
        public IActionResult AddNewEmployee(Emp e){
            emps.Add(e);
            return RedirectToAction("GetEmployeeDetails");
        }
        public IActionResult KnowMore(int id){
             Emp res=emps.Where(x=>x.eid==id).FirstOrDefault();
             return View(res);
        }
        public IActionResult Delete(int id){
            Emp res=emps.Where(x=>x.eid==id).FirstOrDefault();
            emps.Remove(res);
            return RedirectToAction("GetEmployeeDetails");
        }

    }
}