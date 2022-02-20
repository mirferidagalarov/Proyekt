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
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly DataContext _dataContext;

        public DepartmentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(Department department)
        {
            await _dataContext.Departments.AddAsync(department);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int departmentId)
        {
            Department department = await _dataContext.Departments.FindAsync(departmentId);
            department.IsDeleted = true;
            _dataContext.Update(department);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Department> GetId(int departmentId)
        {
            return await _dataContext.Departments.FindAsync(departmentId);
        }

        public async Task<List<Department>> GetList()
        {
            List<Department> departments = await _dataContext.Departments.ToListAsync();
            return departments;
        }

        public async Task Update(Department department)
        {
            _dataContext.Departments.Update(department);
            await _dataContext.SaveChangesAsync();
        }
    }
}
