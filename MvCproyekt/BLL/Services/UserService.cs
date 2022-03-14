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
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task Add(UserToAddDTO userToAddDTO)
        {
            User user = _mapper.Map<User>(userToAddDTO);
            await _userRepository.Add(user);
        }

        public async Task Delete(int userId)
        {
            await _userRepository.Delete(userId);
        }

        public async Task<List<UserToListDTO>> Get()
        {
            List<User> users = await _userRepository.GetList();
            return _mapper.Map<List<UserToListDTO>>(users);

        }

        public async Task<UserToListDTO> GetId(int userId)
        {
            User user = await _userRepository.GetId(userId);
            return _mapper.Map<UserToListDTO>(user);
        }

        public async Task Update(User userToUpdateDTO)
        {
            User user = _mapper.Map<User>(userToUpdateDTO);
           await _userRepository.Update(user);
        }
    }
}
