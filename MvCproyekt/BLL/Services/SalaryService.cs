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
    public class SalaryService: ISalaryService
    {
        private readonly ISalaryRepository  _salaryRepository;
        private readonly IMapper _mapper;
        public SalaryService(ISalaryRepository salaryRepository, IMapper mapper)
        {
            _salaryRepository = salaryRepository;
            _mapper = mapper;
        }

        public async Task Add(SalaryToAddDTO salaryToAddDTO)
        {
            Salarys salary = _mapper.Map<Salarys>(salaryToAddDTO);
            await _salaryRepository.Add(salary);
        }

        public async Task<List<SalaryToListDTO>> Get()
        {
            List<Salarys> salaryys = await _salaryRepository.Get();
            return _mapper.Map<List<SalaryToListDTO>>(salaryys);
        }

        public async Task<SalaryToAddDTO> GetId(int salaryId)
        {
            Salarys salary =await _salaryRepository.GetId(salaryId);
            return _mapper.Map<SalaryToAddDTO>(salary);

        }
    }
}
