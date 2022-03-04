using MvCproyekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.BLL.Services.IServices
{
    public interface IMonthService
    {
        Task<List<MonthToListDTO>> Get();
    }
}
