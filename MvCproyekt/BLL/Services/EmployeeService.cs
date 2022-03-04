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
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task Add(EmployeeToAddDTO employeeToAddDTO)
        {
            Employee employee = _mapper.Map<Employee>(employeeToAddDTO);
            await _employeeRepository.Add(employee);
           
        }

        public async Task Delete(int employeeId)
        {
            await _employeeRepository.Delete(employeeId);
        }

        public async Task<List<EmployeeToListDTO>> Get()
        {
            List<Employee> employees =await _employeeRepository.Get();
           return _mapper.Map<List<EmployeeToListDTO>>(employees);
        }

        public async Task<EmployeeToUpdateDTO> GetId(int employeeId)
        {
            Employee employee = await _employeeRepository.GetId(employeeId);
           return _mapper.Map<EmployeeToUpdateDTO>(employee);
        }

      

        public async Task Update(EmployeeToUpdateDTO employeeToUpdateDTO)
        {
            Employee employee = _mapper.Map<Employee>(employeeToUpdateDTO);
            await _employeeRepository.Update(employee);
        }
    }
}
