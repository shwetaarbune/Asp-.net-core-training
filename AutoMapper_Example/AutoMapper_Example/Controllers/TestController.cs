using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper_Example.Entities;
using AutoMapper_Example.DTOs;

namespace AutoMapper_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        [Route("first-gadget-with-map")]
        public IActionResult GetFirstGadgetWithMapping()
        {
            var gadgets = _myWorldDbContext.Gadgets.FirstOrDefault();
            var result = _mapper.Map<Gadgets, GadgetsDto>(gadgets);
            return Ok(result);
        }
        [HttpGet]
        [Route("all-gadgets-with-mapper")]
        public IActionResult GetAllGadgetsWithMapper()
        {
            var gadgets = _myWorldDbContext.Gadgets.ToList();
            List<GadgetsDto> result = _mapper.Map<List<Gadgets>, List<GadgetsDto>>(gadgets);
            return Ok(result);
        }
        [HttpGet]
        [Route("person-address-with-auto-mapper")]
        public IActionResult GetPersonAddressWithAutoMapper()
        {
            var persons = _myWorldDbContext.Persons.Include(_ => _.PersonAddresses).ToList();
            List<PersonDto> result = _mapper.Map<List<Person>, List<PersonDto>>(persons);
            return Ok(result);
        }
    }
}
