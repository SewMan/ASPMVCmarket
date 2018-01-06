using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPMVCmarket.Dtos;
using ASPMVCmarket.Models;
using AutoMapper;

namespace ASPMVCmarket.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}