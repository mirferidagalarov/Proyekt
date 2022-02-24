using AutoMapper;
using MvCproyekt.BLL.Services.IServices;
using MvCproyekt.DAL.Repositories.IRepositories;
using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services
{
    public class SectorService: ISectorService
    {
        private readonly ISectorRepository _sectorRepository;
        private readonly IMapper _mapper;
        public SectorService(ISectorRepository sectorRepository, IMapper mapper)
        {
            _sectorRepository = sectorRepository;
            _mapper = mapper;
        }

        public async Task Add(SectorToAddDTO sectorToAddDTO)
        {
            Sector sector =  _mapper.Map<Sector>(sectorToAddDTO);
            await _sectorRepository.Add(sector);
        }

        public async Task Delete(int sectorId)
        {
            await _sectorRepository.Delete(sectorId);
        }

        public async Task<List<SectorToListDTO>> Get()
        {
            List<Sector> sectors = await _sectorRepository.Get();
            return _mapper.Map<List<SectorToListDTO>>(sectors);
        }

        public async Task<SectorToUpdateDTO> GetId(int sectorId)
        {
            Sector sector = await _sectorRepository.GetId(sectorId);
            return _mapper.Map<SectorToUpdateDTO>(sector);

        }

        public async Task Update(SectorToUpdateDTO sectorToUpdateDTO)
        {
            Sector sector = _mapper.Map<Sector>(sectorToUpdateDTO);
            await _sectorRepository.Update(sector);
        }
    }
}
