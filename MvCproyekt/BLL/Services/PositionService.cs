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
    public class PositionService: IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;
        public PositionService(IPositionRepository positionRepository,IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }
        public async Task<List<PositionToListDTO>> Get()
        {
            List<Position> positions = await _positionRepository.Get();
            return _mapper.Map<List<PositionToListDTO>>(positions);
        }
    }
}
