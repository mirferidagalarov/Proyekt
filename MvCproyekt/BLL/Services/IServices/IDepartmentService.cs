using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface IDepartmentService
    {
        Task<List<DepartmentToListDTO>> Get();
        Task<DepartmentToListDTO> GetId(int departmentId);
        Task Add(DepartmentToAddDTO  departmentToAddDTO);
        Task Update(DepartmentToUpdateDTO  departmentToUpdateDTO);
        Task Delete(int departmentId);
    }
}
