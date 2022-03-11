using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace finalmvc.Models
{
    public class User
    {
        [Display(Name="Enter your Username")]
        [Required(ErrorMessage="Username is required")]
        public string username{get;set;}

        [Display(Name="Enter your Password")]
        [Required(ErrorMessage="Password is required")]
        [DataType(DataType.Password)]
        public string pass{get;set;}
    }
}