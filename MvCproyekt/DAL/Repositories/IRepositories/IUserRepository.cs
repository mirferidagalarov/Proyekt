using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetList();
        Task<User> GetId(int userId);
        Task Add(User user);
        Task Update(User user);
        Task Delete(int userId);

    }
}
