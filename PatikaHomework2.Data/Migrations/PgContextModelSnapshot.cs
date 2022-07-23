﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PatikaHomework2.Data.Context;

#nullable disable

namespace PatikaHomework2.Data.Migrations
{
    [DbContext(typeof(PgContext))]
    partial class PgContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Continent")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("country");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("integer");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("department");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<int?>("FolderId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessType")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("folder");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Country", b =>
                {
                    b.HasOne("PatikaHomework2.Dto.Dto.Department", null)
                        .WithMany("Country")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Department", b =>
                {
                    b.HasOne("PatikaHomework2.Dto.Dto.Employee", null)
                        .WithMany("Department")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Employee", b =>
                {
                    b.HasOne("PatikaHomework2.Dto.Dto.Folder", null)
                        .WithMany("Employee")
                        .HasForeignKey("FolderId");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Department", b =>
                {
                    b.Navigation("Country");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Employee", b =>
                {
                    b.Navigation("Department");
                });

            modelBuilder.Entity("PatikaHomework2.Dto.Dto.Folder", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
