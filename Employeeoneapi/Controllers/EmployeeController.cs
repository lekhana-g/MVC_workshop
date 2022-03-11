using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employeeoneapi.Repo;
using Employeeoneapi.Models;
// using FlightApi.Service;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employeeoneapi
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo<Employee> pr;
        public EmployeeController(IEmployeeRepo<Employee> repo)
        {
            pr = repo;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return pr.GetEmployees();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return pr.GetEmployeebyId(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Employee p)
        {
            pr.AddEmployee(p);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee p)
        {
            pr.DeleteEmployee(p.Employeeid);
            pr.AddEmployee(p);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pr.DeleteEmployee(id);
        }
    }
}
