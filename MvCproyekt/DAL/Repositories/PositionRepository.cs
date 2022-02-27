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
    public class PositionRepository: IPositionRepository
    {
        private readonly DataContext _dataContext;
        public PositionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Position>> Get()
        {
            List<Position> positions = await _dataContext.Positions.ToListAsync();
            return positions;
        }
    }
}
