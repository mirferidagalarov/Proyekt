using Microsoft.EntityFrameworkCore;
using MvCproyekt.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvCproyekt.DAL.DatabaseContext
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department>  Departments { get; set; }
        public DbSet<Sector> Sectors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Sector>().HasQueryFilter(m => !m.IsDeleted);
        }

    }
}
