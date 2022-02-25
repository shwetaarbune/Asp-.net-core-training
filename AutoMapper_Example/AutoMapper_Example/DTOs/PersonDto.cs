using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Example.DTOs
{
    public class PersonDto
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public List<PersonAddressDto> PersonAddresses { get; set; }
    }
}
