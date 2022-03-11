using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 namespace flightapi.Models
 {
     public class FlightD : IFlightD<FlightD>{
         public int Fid { get; set; }
        public string Fname { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Departuretime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int Totalcapacity { get; set; }
        public int Costperseat { get; set; }
     
        public static List<FlightD> fs=new List<FlightD>();
        public FlightD(){

        }
       public FlightD(int fid,string fname,string source,string destination,DateTime deptime,DateTime arrtime,int tc,int cps  ){
          Fid=fid;Fname=fname;
          Source=source;Destination=destination;
          Departuretime=deptime;Arrivaltime=arrtime;
          Totalcapacity=tc;Costperseat=cps;
       }
       public List<FlightD> GetFlights(){
           //yr,month,day,hr,min,secs
        //    fs.Add(new FlightD(1,"AirIndia","Bangalore","Hyderabad",new DateTime(2022,03,12,3,40,00),new DateTime(2022,03,12,5,40,00),200,1500));
        //    fs.Add(new FlightD(2,"Vistara","Goa","Delhi",new DateTime(2022,03,13,11,40,00),new DateTime(2022,03,13,13,25,00),300,2500));
        //    fs.Add(new FlightD(3,"Indigo","Hyderbad","Delhi",new DateTime(2022,03,14,5,40,00),new DateTime(2022,03,14,7,40,00),100,3500));
           return fs;
       }
        public void AddFlight(FlightD f)
        {
            fs.Add(f);
        }
        public void DeleteFlight(int id)
        {
            FlightD F = GetFlightById(id);
            fs.Remove(F);
        }
        public FlightD GetFlightById(int id)
        {
            fs= GetFlights();
            FlightD f = fs.Where(f=>f.Fid==id).FirstOrDefault();
            return f;
        }
     }
 }