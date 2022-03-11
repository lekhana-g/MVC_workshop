using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Employeeoneapi.Models
{
    public class Employee:IEmployee <Employee>
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public static List<Employee> flght = new List<Employee>();
        public Employee()
        {

        }
        public Employee(int fid,string fname,int seat,int price) 
        {
            Employeeid= fid;
            Employeename = fname;
            Age = seat;
            Salary = price;

        }
        public List<Employee> GetEmployees()
        {
            return flght;
        } 
        public void AddEmployee(Employee p)
        {
        flght.Add(p);

        }
        public void DeleteEmployee(int id)
        {
            Employee P = GetEmployeebyId(id);
            flght.Remove(P);
        }
        public  Employee GetEmployeebyId(int id)
        {
            flght = GetEmployees();
             Employee p = flght.Where(p=>p.Employeeid==id).FirstOrDefault();
            return p;
        }
    }
}
