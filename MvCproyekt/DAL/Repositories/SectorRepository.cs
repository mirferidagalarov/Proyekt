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
    public class SectorRepository: ISectorRepository
    {
        private readonly DataContext _dataContext;
        public SectorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(Sector sector)
        {
           await _dataContext.Sectors.AddAsync(sector);
           await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int sectorId)
        {
            Sector sector = await _dataContext.Sectors.FindAsync(sectorId);
            sector.IsDeleted = true;
            _dataContext.Update(sector);
            await _dataContext.SaveChangesAsync();

        }

        public async Task<List<Sector>> Get()
        {
         List<Sector> sectors= await _dataContext.Sectors.Include(m=>m.Department).ToListAsync();
            return sectors;
        }

        public async Task<Sector> GetId(int sectorId)
        {
            return await _dataContext.Sectors.FindAsync(sectorId);
        }

        public async Task Update(Sector sector)
        {
            _dataContext.Sectors.Update(sector);
            await _dataContext.SaveChangesAsync();
        }
    }
}
