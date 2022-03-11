using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employeeoneapi.Models;

namespace Employeeoneapi.Repo
{
    public interface IEmployeeRepo<Employee>
    {
        public void AddEmployee(Employee p);
        public void DeleteEmployee(int id);
        public List<Employee> GetEmployees();
        public Employee GetEmployeebyId(int id);

    }

    
}
