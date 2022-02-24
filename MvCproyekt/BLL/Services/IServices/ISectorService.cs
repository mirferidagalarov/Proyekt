using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface ISectorService
    {
        Task<List<SectorToListDTO>> Get();
        Task<SectorToUpdateDTO> GetId(int sectorId);
        Task Add(SectorToAddDTO sectorToAddDTO);
        Task Update(SectorToUpdateDTO sectorToUpdateDTO);
        Task Delete(int sectorId);


    }
}
