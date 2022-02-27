using Microsoft.EntityFrameworkCore;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.DAL.Repositories.IRepositories;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(Employee employee)
        {
           await _dataContext.Employees.AddAsync(employee);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int employeeId)
        {
            Employee employee = await _dataContext.Employees.FindAsync(employeeId);
            employee.IsDeleted = true;
            _dataContext.Employees.Update(employee);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> Get()
        {
            List<Employee> employees = await _dataContext.Employees.Include(m=>m.Department).Include(m=>m.Sector).Include(m=>m.Position).ToListAsync();
            return employees;
        }

        public async Task<Employee> GetId(int employeeId)
        {
            return await _dataContext.Employees.FindAsync(employeeId);
        }

      

        public async Task Update(Employee employee)
        {
            _dataContext.Employees.Update(employee);
            await _dataContext.SaveChangesAsync();
        }
    }
}
