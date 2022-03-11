using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using thridmvc.Models;
namespace thirdmvc.Controllers{
    public class StudentController:Controller{
        public IActionResult Addnumbers(){
            return View();
        }
        [HttpPost]
        public IActionResult Addnumbers(IFormCollection f){
            int a=Convert.ToInt32(f["first"]);
            int b=Convert.ToInt32(f["second"]);
            int c=a+b;
            ViewBag.result=c;
            //using session we can use variables across the controllers
            HttpContext.Session.SetString("result",c.ToString());
            //return View();
            return RedirectToAction("StudentResult");
        }
        public IActionResult StudentResult(){
            ViewBag.result=HttpContext.Session.GetString("result");
            return View();
        }
} 
    }