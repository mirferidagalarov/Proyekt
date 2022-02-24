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
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task Add(DepartmentToAddDTO departmentToAddDTO)
        {
            Department  department = _mapper.Map<Department>(departmentToAddDTO);
            await _departmentRepository.Add(department);
        }

        public async Task Delete(int departmentId)
        {
            await _departmentRepository.Delete(departmentId);
        }

        public async Task<List<DepartmentToListDTO>> Get()
        {
            List<Department> departments = await _departmentRepository.GetList();
            return _mapper.Map<List<DepartmentToListDTO>>(departments);
        }

        public async Task<DepartmentToUpdateDTO> GetId(int departmentId)
        {
            Department department = await _departmentRepository.GetId(departmentId);
            return _mapper.Map<DepartmentToUpdateDTO>(department);
        }

        public async Task Update(DepartmentToUpdateDTO departmentToUpdateDTO)
        {
            Department department = _mapper.Map<Department>(departmentToUpdateDTO);
            await _departmentRepository.Update(department);
        }
    }
}
