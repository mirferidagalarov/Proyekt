using AutoMapper;
using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Core
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<User, UserToListDTO>();
            CreateMap<UserToAddDTO, User>();
            CreateMap<UserToUpdateDTO, User>();
            CreateMap<Department, DepartmentToListDTO>();
            CreateMap<DepartmentToAddDTO, Department>();
            CreateMap<DepartmentToUpdateDTO, Department>();
            CreateMap<Sector, SectorToListDTO>();
            CreateMap<SectorToAddDTO, Sector>();
            CreateMap<SectorToUpdateDTO, Sector>().ReverseMap();
            CreateMap<Employee, EmployeeToListDTO>().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => src.DateofBirth.ToString("dd-MMM-yyyy")));
            CreateMap<EmployeeToAddDTO, Employee>().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => Convert.ToDateTime(src.DateofBirth.ToString("dd-MMM-yyyy"))));
            CreateMap<EmployeeToUpdateDTO, Employee>().ReverseMap().ForMember(dest => dest.DateofBirth, opt => opt.MapFrom(src => src.DateofBirth.ToString("dd-MMM-yyyy"))); ;
            CreateMap<Position, PositionToListDTO>();
            CreateMap<Month, MonthToListDTO>();
            CreateMap<Years, YearToListDTO>();
            CreateMap<Salarys, SalaryToListDTO>();
            CreateMap<SalaryToAddDTO, Salarys>();



        }
    }
}
