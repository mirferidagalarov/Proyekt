using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetList();
        Task<Department> GetId(int departmentId);
        Task Add(Department department);
        Task Update(Department department);
        Task Delete(int departmentId);
    }
}
