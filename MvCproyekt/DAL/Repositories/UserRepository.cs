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
    public class UserRepository: IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(User user)
        {
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();

        }

        public async Task Delete(int userId)
        {
            User user = await _dataContext.Users.FindAsync(userId);
            user.IsDeleted = true;
            _dataContext.Update(user);
           await _dataContext.SaveChangesAsync();
        }

        public async Task<User> GetId(int userId)
        {
            return await _dataContext.Users.FindAsync(userId);
        }

        public async Task<List<User>> GetList()
        {
            List<User> users = await _dataContext.Users.ToListAsync();
            return users;
        }

        public async Task Update(User user)
        {
             _dataContext.Users.Update(user);
            await _dataContext.SaveChangesAsync();
        }
    }
}
