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
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Sector>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Position>().HasData(
                 new Position
                 {
                     PositionId = 1,
                     PositionName = "Chief Information Officer"
                 },
                 new Position
                 {
                     PositionId = 2,
                     PositionName = "Chief Technology Officer"
                 },
                 new Position
                 {
                     PositionId = 3,
                     PositionName = "Director of Technology"
                 },
                 new Position
                 {
                     PositionId = 4,
                     PositionName = "IT Director"
                 },
                  new Position
                  {
                      PositionId = 5,
                      PositionName = "IT Manager"
                  },
                   new Position
                   {
                       PositionId = 6,
                       PositionName = "Information Security Analyst"
                   },
                   new Position
                   {
                       PositionId = 7,
                       PositionName = "Junior Developer"
                   },
                   new Position
                   {
                       PositionId = 8,
                       PositionName = "Senior Software Engineer"
                   },
                   new Position
                   {
                       PositionId = 9,
                       PositionName = "Software Architect"
                   },
                   new Position
                   {
                       PositionId = 10,
                       PositionName = ".Net Developer"
                   }
                   );
        }

    }
}
