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
    public class MonthService: IMonthService
    {
        private readonly IMonthRepository _monthRepository;
        private readonly IMapper _mapper;
        public MonthService(IMonthRepository monthRepository, IMapper mapper)
        {
            _monthRepository = monthRepository;
            _mapper = mapper;
        }

        public async Task<List<MonthToListDTO>> Get()
        {
            List<Month> months = await _monthRepository.Get();
            return _mapper.Map<List<MonthToListDTO>>(months);
        }
    }
}
