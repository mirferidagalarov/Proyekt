using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface ISectorRepository
    {
        Task<List<Sector>> Get();
        Task<Sector> GetId(int sectorId);
        Task Add(Sector sector);
        Task Update(Sector sector);
        Task Delete(int sectorId);

    }
}
