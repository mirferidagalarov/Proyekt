﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvCproyekt.DAL.DatabaseContext;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MvCproyekt.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MvCproyekt.Entities.Chart", b =>
                {
                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Proname")
                        .HasColumnType("text");

                    b.HasKey("Stock");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("StockAmount")
                        .HasColumnType("integer");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeSurname")
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.Property<int>("SectorId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("PositionId");

                    b.HasIndex("SectorId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Month", b =>
                {
                    b.Property<int>("MonthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("MonthName")
                        .HasColumnType("text");

                    b.HasKey("MonthId");

                    b.ToTable("Months");

                    b.HasData(
                        new
                        {
                            MonthId = 1,
                            MonthName = "Yanvar"
                        },
                        new
                        {
                            MonthId = 2,
                            MonthName = "Fevral"
                        },
                        new
                        {
                            MonthId = 3,
                            MonthName = "Mart"
                        },
                        new
                        {
                            MonthId = 4,
                            MonthName = "Aprel"
                        },
                        new
                        {
                            MonthId = 5,
                            MonthName = "May"
                        },
                        new
                        {
                            MonthId = 6,
                            MonthName = "Iyun"
                        },
                        new
                        {
                            MonthId = 7,
                            MonthName = "Iyul"
                        },
                        new
                        {
                            MonthId = 8,
                            MonthName = "Avqust"
                        },
                        new
                        {
                            MonthId = 9,
                            MonthName = "Sentaybr"
                        },
                        new
                        {
                            MonthId = 10,
                            MonthName = "Oktyabr"
                        },
                        new
                        {
                            MonthId = 11,
                            MonthName = "Noyabr"
                        },
                        new
                        {
                            MonthId = 12,
                            MonthName = "Dekabr"
                        });
                });

            modelBuilder.Entity("MvCproyekt.Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("text");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            PositionName = "Chief Information Officer"
                        },
                        new
                        {
                            PositionId = 2,
                            PositionName = "Chief Technology Officer"
                        },
                        new
                        {
                            PositionId = 3,
                            PositionName = "Director of Technology"
                        },
                        new
                        {
                            PositionId = 4,
                            PositionName = "IT Director"
                        },
                        new
                        {
                            PositionId = 5,
                            PositionName = "IT Manager"
                        },
                        new
                        {
                            PositionId = 6,
                            PositionName = "Information Security Analyst"
                        },
                        new
                        {
                            PositionId = 7,
                            PositionName = "Junior Developer"
                        },
                        new
                        {
                            PositionId = 8,
                            PositionName = "Senior Software Engineer"
                        },
                        new
                        {
                            PositionId = 9,
                            PositionName = "Software Architect"
                        },
                        new
                        {
                            PositionId = 10,
                            PositionName = ".Net Developer"
                        });
                });

            modelBuilder.Entity("MvCproyekt.Entities.Salarys", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MonthId")
                        .HasColumnType("integer");

                    b.Property<double>("Salary")
                        .HasColumnType("double precision");

                    b.Property<int>("YearId")
                        .HasColumnType("integer");

                    b.HasKey("SalaryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MonthId");

                    b.HasIndex("YearId");

                    b.ToTable("Salariys");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Sector", b =>
                {
                    b.Property<int>("SectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("SectorName")
                        .HasColumnType("text");

                    b.HasKey("SectorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sectors");
                });

            modelBuilder.Entity("MvCproyekt.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Years", b =>
                {
                    b.Property<int>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("YearId");

                    b.ToTable("Years");

                    b.HasData(
                        new
                        {
                            YearId = 1,
                            Year = 2020
                        },
                        new
                        {
                            YearId = 2,
                            Year = 2021
                        },
                        new
                        {
                            YearId = 3,
                            Year = 2022
                        },
                        new
                        {
                            YearId = 4,
                            Year = 2023
                        },
                        new
                        {
                            YearId = 5,
                            Year = 2024
                        });
                });

            modelBuilder.Entity("MvCproyekt.Entities.Employee", b =>
                {
                    b.HasOne("MvCproyekt.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvCproyekt.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvCproyekt.Entities.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Position");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Salarys", b =>
                {
                    b.HasOne("MvCproyekt.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvCproyekt.Entities.Month", "Month")
                        .WithMany()
                        .HasForeignKey("MonthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvCproyekt.Entities.Years", "Year")
                        .WithMany()
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Month");

                    b.Navigation("Year");
                });

            modelBuilder.Entity("MvCproyekt.Entities.Sector", b =>
                {
                    b.HasOne("MvCproyekt.Entities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
