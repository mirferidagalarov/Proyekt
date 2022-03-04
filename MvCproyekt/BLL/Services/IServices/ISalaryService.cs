using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface ISalaryService
    {
        Task<List<SalaryToListDTO>> Get();
        Task<SalaryToAddDTO> GetId(int salaryId);
        Task Add(SalaryToAddDTO salaryToAddDTO);
    }
}
