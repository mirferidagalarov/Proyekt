using Microsoft.EntityFrameworkCore;
using MvCproyekt.DAL.DatabaseContext;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public class SalaryRepository: ISalaryRepository
    {
        private readonly DataContext _dataContext;
        public SalaryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(Salarys salarys)
        {
           await _dataContext.Salariys.AddAsync(salarys);
           await _dataContext.SaveChangesAsync();


        }

        public async Task<List<Salarys>> Get()
        {
            List<Salarys> salaryys = await _dataContext.Salariys.Include(m=>m.Month).Include(m=>m.Year).Include(m=>m.Employee).ToListAsync();
            return salaryys;
        }
        //.Where(m => m.EmployeeId == salaryId)

        public async Task<Salarys> GetId(int salaryId)
        {
            return await _dataContext.Salariys.FindAsync(salaryId);
        }
    }
}
