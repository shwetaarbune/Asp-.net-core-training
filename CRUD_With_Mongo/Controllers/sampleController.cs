using Employee.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDopsWithMongo.Controllers
{
    public class sampleController : Controller
    {
        private readonly IEmployeeServices _employeeServices;
        public sampleController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
