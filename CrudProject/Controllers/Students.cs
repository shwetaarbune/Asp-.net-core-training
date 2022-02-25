using CrudProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        List<Studentcs> _oStudents = new List<Studentcs>()
        {
            new Studentcs(){Id=1,Name="shweta",Roll=205},
            new Studentcs(){Id=2,Name="shivani",Roll=204},
            new Studentcs(){Id=3,Name="shravani",Roll=206},
            new Studentcs(){Id=4,Name="prakarsh",Roll=203},


        };
        [HttpGet]
        public IActionResult Gets()
        {
            if (_oStudents.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_oStudents);
        }
        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var oStudent = _oStudents.SingleOrDefault(x => x.Id == id);
            if (oStudent == null)
            {
                return NotFound("No students Found");
            }
            return Ok(oStudent);
        }
        [HttpPost]
        public IActionResult Save(Studentcs oStudent)
        {
            _oStudents.Add(oStudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_oStudents);
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var oStudent = _oStudents.SingleOrDefault(x => x.Id == id);
            if (oStudent == null)
            {
                return NotFound("No student Found");
            }
            _oStudents.Remove(oStudent);
            if (_oStudents.Count == 0)
            {
                return NotFound("No list found.");
            }
            return Ok(_oStudents);
        }


    }
}
