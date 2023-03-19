﻿// <auto-generated />
using System;
using EMSApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20230319114624_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeManagementSystem.Models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"), 1L, 1);

                    b.Property<string>("Dept_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dept_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_Id"), 1L, 1);

                    b.Property<int>("Dep_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Emp_DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emp_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.HasIndex("Dep_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Dep_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
