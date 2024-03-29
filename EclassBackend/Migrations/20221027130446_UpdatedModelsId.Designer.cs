﻿// <auto-generated />
using System;
using EclassBackend.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EclassBackend.Migrations
{
    [DbContext(typeof(EclassContext))]
    [Migration("20221027130446_UpdatedModelsId")]
    partial class UpdatedModelsId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseProfessor", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorsID")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "ProfessorsID");

                    b.HasIndex("ProfessorsID");

                    b.ToTable("CourseProfessors", (string)null);
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "StudentsID");

                    b.HasIndex("StudentsID");

                    b.ToTable("CourseStudents", (string)null);
                });

            modelBuilder.Entity("EclassBackend.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Classroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ECTS")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<int?>("LabId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LabId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EclassBackend.Models.Lab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Classroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("EclassBackend.Models.Professor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("EclassBackend.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GPA")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("hasThesis")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseProfessor", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EclassBackend.Models.Course", b =>
                {
                    b.HasOne("EclassBackend.Models.Lab", "Lab")
                        .WithMany()
                        .HasForeignKey("LabId");

                    b.Navigation("Lab");
                });
#pragma warning restore 612, 618
        }
    }
}
