using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeeoneapi.Models
{
   public interface IEmployee<Employee>
    {
        public void AddEmployee(Employee f);
        public void DeleteEmployee(int id);
        public List<Employee>GetEmployees();
        public Employee GetEmployeebyId(int id);
    }
}
