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
        public DbSet<Salarys> Salariys { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Years> Years { get; set; }
        public DbSet<Chart> Charts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Sector>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Salarys>().HasQueryFilter(m => !m.IsDeleted);
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
            modelBuilder.Entity<Month>().HasData(
                new Month
                {
                    MonthId = 1,
                    MonthName = "Yanvar"
                },
                  new Month
                  {
                      MonthId = 2,
                      MonthName = "Fevral"
                  },
                    new Month
                    {
                        MonthId = 3,
                        MonthName = "Mart"
                    },
                      new Month
                      {
                          MonthId = 4,
                          MonthName = "Aprel"
                      },
                        new Month
                        {
                            MonthId = 5,
                            MonthName = "May"
                        },
                          new Month
                          {
                              MonthId = 6,
                              MonthName = "Iyun"
                          },
                            new Month
                            {
                                MonthId = 7,
                                MonthName = "Iyul"
                            },
                              new Month
                              {
                                  MonthId = 8,
                                  MonthName = "Avqust"
                              },
                                new Month
                                {
                                    MonthId = 9,
                                    MonthName = "Sentaybr"
                                },
                                  new Month
                                  {
                                      MonthId = 10,
                                      MonthName = "Oktyabr"
                                  },
                                    new Month
                                    {
                                        MonthId = 11,
                                        MonthName = "Noyabr"
                                    },
                                      new Month
                                      {
                                          MonthId = 12,
                                          MonthName = "Dekabr"
                                      }


                );
            modelBuilder.Entity<Years>().HasData(
                new Years
                {
                    YearId = 1,
                    Year = 2020
                },
                 new Years
                 {
                     YearId = 2,
                     Year = 2021
                 },
                  new Years
                  {
                      YearId = 3,
                      Year = 2022
                  },
                   new Years
                   {
                       YearId = 4,
                       Year = 2023
                   },
                    new Years
                    {
                        YearId = 5,
                        Year = 2024
                    }


                );

        }

    }
}
