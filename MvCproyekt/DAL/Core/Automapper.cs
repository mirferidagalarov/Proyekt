using AutoMapper;
using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Core
{
    public class Automapper:Profile
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


        }
    }
}
