using AutoMapper;
using MoviesWebsite.Dtos;
using MoviesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesWebsite.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           // Mapper.CreateMap<Customer, CustomerDto>();
           // Mapper.CreateMap<CustomerDto, Customer>();
           // Mapper.CreateMap<Movie, MovieDto>().ReverseMap();


            Mapper.CreateMap<Customer, CustomerDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Movie, MovieDto>().ReverseMap().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MembershipType, MembershipTypeDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<Genre, GenreDto>().ReverseMap().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}