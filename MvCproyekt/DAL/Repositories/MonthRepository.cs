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
    public class MonthRepository : IMonthRepository
    {
        private readonly DataContext _dataContext;
        public MonthRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Month>> Get()
        {
            List<Month> months = await _dataContext.Months.ToListAsync();
            return months;
        }
    }
}
