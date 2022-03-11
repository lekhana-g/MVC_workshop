using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace finalmvc.Models
{
    public class FlightD
    {
       [Display(Name="Flight ID")]
       [Required(ErrorMessage="Flight id is required")]
        public int Fid { get; set; }

       [Display(Name="Flight Name")]
       [Required(ErrorMessage="Flight name is required")]
        public string Fname { get; set; }

        [Display(Name="Source")]
       [Required(ErrorMessage="Source is required")]
        public string Source { get; set; }

        [Display(Name="Destination")]
       [Required(ErrorMessage="Destination is required")]
        public string Destination { get; set; }

        [Display(Name="Departure time")]
       [Required(ErrorMessage="dep time is required")]
        public DateTime Departuretime { get; set; }
        
        [Display(Name="Arrival Time")]
       [Required(ErrorMessage="arrival time is required")]
        public DateTime Arrivaltime { get; set; }

        [Display(Name="Capacity of flight")]
       [Required(ErrorMessage="Flight capacity is required")]
        public int Totalcapacity { get; set; }

        [Display(Name="Cost per seat")]
       [Required(ErrorMessage="Cost per seat is required")]
        public int Costperseat { get; set; }
    }
}