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
