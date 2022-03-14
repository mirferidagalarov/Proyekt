using MvCproyekt.Entities;
using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface IUserService
    {
        Task<List<UserToListDTO>> Get();
        Task<UserToListDTO> GetId(int userId);
        Task Add(UserToAddDTO userToAddDTO);
        Task Update(User yoxla);
        Task Delete(int userId);
    }
}
