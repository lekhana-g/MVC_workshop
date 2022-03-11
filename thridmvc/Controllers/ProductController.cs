using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using thridmvc.Models;
namespace thridmvc.Controllers
{
    public class ProductController:Controller
    {
       //  private IReadOnly IHttpContextAccessor _httpContextAccessor;

        public IActionResult Login(){
            return View();

        }
        [HttpPost]
        public IActionResult Login(User u){
            CookieOptions opt=new CookieOptions();
            if(u.username=="admin" && u.pass=="pass"){

            }
        }
    }
}