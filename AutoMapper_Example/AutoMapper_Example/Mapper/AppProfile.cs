using AutoMapper;
using AutoMapper_Example.DTOs;
using AutoMapper_Example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper_Example.Mapper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonAddress, PersonAddressDto>();
        }
    }
}
