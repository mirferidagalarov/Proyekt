using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> Get();
        Task<Employee> GetId(int employeeId);
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(int employeeId);
      

    }
}
