using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface IEmployeeService
    {
        Task<List<EmployeeToListDTO>> Get();
        Task<EmployeeToUpdateDTO> GetId(int employeeId);
        Task Add(EmployeeToAddDTO employeeToAddDTO);
        Task Update(EmployeeToUpdateDTO employeeToUpdateDTO);
        Task Delete(int employeeId);
       

    }
}
