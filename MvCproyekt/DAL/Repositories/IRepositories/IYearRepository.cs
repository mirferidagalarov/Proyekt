﻿using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.Repositories.IRepositories
{
    public interface IYearRepository
    {
        Task<List<Years>> Get();
    }
}
