using Employee.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDopsWithMongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly  IEmployeeServices _employeeServices;

        public EmployeesController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices; 
        }
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeServices.GetEmployees());
        }
        [HttpGet("{id}", Name = "GetEmployee")]
        public IActionResult GetEmployee(string id)
        {
           return Ok(_employeeServices.GetEmployee(id));
        }
        [HttpPost]
        public IActionResult AddEmployee (Employees employee)
        {
    
            _employeeServices.AddEmployee(employee);
            return CreatedAtRoute("GetEmployee", new { id = employee.Id }, employee);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(string id)
        {
            _employeeServices.DeleteEmployee(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employees employee)
        {
            return Ok(_employeeServices.UpdateEmployee(employee));
        }
    }
}
