using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface ISalaryRepository
    {
        Task<List<Salarys>> Get();
        Task<Salarys> GetId(int salaryId);
        Task Add(Salarys salarys);

    }
}
