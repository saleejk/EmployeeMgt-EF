﻿// <auto-generated />
using EmployeeMgt_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeMgt_EF.Migrations
{
    [DbContext(typeof(DbContextClass))]
    partial class DbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeMgt_EF.ModelEntity.Employee", b =>
                {
                    b.Property<int>("E_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("E_id"));

                    b.Property<string>("E_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("E_role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("E_salary")
                        .HasColumnType("int");

                    b.HasKey("E_id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
