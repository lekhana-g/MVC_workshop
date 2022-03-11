using Employeeoneapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeoneapi.Repo
{
    public class EmployeeRepo:IEmployeeRepo<Employee>
    {
        private readonly IEmployee<Employee> p;
        public EmployeeRepo()
        {

        }
        public EmployeeRepo(IEmployee<Employee> _p)
        {
            p = _p;
        }
        public void AddEmployee(Employee p)
        {
            p.AddEmployee(p);   
        }

        public void DeleteEmployee(int id)
        {
            p.DeleteEmployee(id);
        }

        public Employee GetEmployeebyId(int id)
        {
            return p.GetEmployeebyId(id);
        }

        public List<Employee> GetEmployees()
        {
           return p.GetEmployees();
        }
    }
}
