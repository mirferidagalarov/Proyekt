using AutoMapper;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.DAL.Repositories.IRepositories;
using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services
{
    public class YearService: IYearService
    {
        private readonly IYearRepository _yearRepository;
        private readonly IMapper _mapper;
        public YearService(IYearRepository yearRepository, IMapper mapper)
        {
            _yearRepository = yearRepository;
            _mapper = mapper;
        }

        public async Task<List<YearToListDTO>> Get()
        {
            List<Years> years = await _yearRepository.Get();
            return _mapper.Map<List<YearToListDTO>>(years);
        }
    }
}
