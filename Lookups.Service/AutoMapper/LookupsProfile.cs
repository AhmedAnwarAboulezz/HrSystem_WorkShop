using AutoMapper;
using Common.StandardInfrastructure;
using Lookups.Data.Entities;
using Lookups.Service.Dto;
using Microsoft.AspNetCore.Http;

namespace Lookups.Service.AutoMapper
{
    public class LookupsProfile : Profile
    {

        public LookupsProfile()
        {
            MapCountry();            
            MapGender();
            MapEmployee();
            MapEmployeeLog();
        }

        

        private void MapCountry()
        {
            CreateMap<CountryDto, Country>().ReverseMap();
            CreateMap<DropDownDto, Country>().ReverseMap();

        }

        private void MapGender()
        {
            CreateMap<GenderDto, Gender>().ReverseMap();
            CreateMap<DropDownDto, Gender>().ReverseMap();

        }

        private void MapEmployee()
        {
            CreateMap<AddUpdateEmployeeDto, Employee>().ReverseMap();
            CreateMap<GetEmployeeDto, Employee>().ReverseMap()
                .ForMember(dest => dest.CountryNameFl, opts => opts.MapFrom(src => src.Country.NameFl))
                .ForMember(dest => dest.CountryNameSl, opts => opts.MapFrom(src => src.Country.NameSl))
                .ForMember(dest => dest.GenderNameFl, opts => opts.MapFrom(src => src.Gender.NameFl))
                .ForMember(dest => dest.GenderNameSl, opts => opts.MapFrom(src => src.Gender.NameSl))
                .ForMember(dest => dest.ManagerNameFl, opts => opts.MapFrom(src => src.Manager != null ? src.Manager.NameFl : "-"))
                .ForMember(dest => dest.ManagerNameSl, opts => opts.MapFrom(src => src.Manager != null ? src.Manager.NameSl : "-"));
            CreateMap<EmployeeDropDownDto, Employee>().ReverseMap();
        }

        private void MapEmployeeLog()
        {
            CreateMap<GetEmployeeLogDto, EmployeeLog>().ReverseMap()
                .ForMember(dest => dest.EmployeeCode, opts => opts.MapFrom(src => src.Employee.Code))
                .ForMember(dest => dest.EmployeeNameFl, opts => opts.MapFrom(src => src.Employee.NameFl))
                .ForMember(dest => dest.EmployeeNameSl, opts => opts.MapFrom(src => src.Employee.NameSl));
        }


    }
   
}
