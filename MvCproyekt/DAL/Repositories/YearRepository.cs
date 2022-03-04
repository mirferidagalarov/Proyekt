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
    public class YearRepository: IYearRepository
    {
        private readonly DataContext _dataContext;
        public YearRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Years>> Get()
        {
            List<Years> years = await _dataContext.Years.ToListAsync();
            return years;
        }
    }
}
