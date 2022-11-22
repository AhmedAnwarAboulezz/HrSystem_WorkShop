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
        }
      
        private void MapGender()
        {
            CreateMap<GenderDto, Gender>().ReverseMap()
                .ForMember(dest => dest.GenderNameFl, opts =>
                opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.Ar ||
                Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.NameSl : src.NameFl))
                .ForMember(dest => dest.GenderNameSl,
                opts => opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.En
                 || Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.NameFl : src.NameSl));
            CreateMap<DropdownDto, Gender>().ReverseMap()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))

                .ForMember(dest => dest.NameFl, opts =>
                opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.Ar ||
                Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.NameSl : src.NameFl))
                .ForMember(dest => dest.NameSl,
                opts => opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.En
                 || Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.NameFl : src.NameSl));

        }

        private void MapEmployee()
        {
            CreateMap<AddUpdateEmployeeDto, Employee>().ReverseMap();
            CreateMap<GetEmployeeDto, Employee>().ReverseMap()
                .ForMember(dest => dest.CountryNameFl, opts => opts.MapFrom(src => src.Country.NameFl))
                .ForMember(dest => dest.CountryNameSl, opts => opts.MapFrom(src => src.Country.NameSl))
                .ForMember(dest => dest.GenderNameFl, opts => opts.MapFrom(src => src.Gender.NameFl))
                .ForMember(dest => dest.GenderNameSl, opts => opts.MapFrom(src => src.Country.NameSl))
                .ForMember(dest => dest.ManagerNameFl, opts => opts.MapFrom(src => src.Manager != null ? src.Manager.NameFl : "-"))
                .ForMember(dest => dest.ManagerNameSl, opts => opts.MapFrom(src => src.Manager != null ? src.Manager.NameSl : "-"));
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
