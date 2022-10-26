﻿// <auto-generated />
using System;
using EclassBackend.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EclassBackend.DAL.Migrations
{
    [DbContext(typeof(EclassContext))]
    [Migration("20221026121044_Initial-Create")]
    partial class InitialCreate
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
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorsProfessorID")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "ProfessorsProfessorID");

                    b.HasIndex("ProfessorsProfessorID");

                    b.ToTable("CourseProfessor");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsID")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "StudentsID");

                    b.HasIndex("StudentsID");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("EclassBackend.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

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

                    b.HasKey("CourseId");

                    b.HasIndex("LabId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EclassBackend.Models.CourseProfessors", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorID")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "ProfessorID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("CourseProfessors");
                });

            modelBuilder.Entity("EclassBackend.Models.CourseStudents", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseStudents");
                });

            modelBuilder.Entity("EclassBackend.Models.Lab", b =>
                {
                    b.Property<int>("LabId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LabId"), 1L, 1);

                    b.Property<string>("Classroom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LabId");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("EclassBackend.Models.LabProfessors", b =>
                {
                    b.Property<int>("LabId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorID")
                        .HasColumnType("int");

                    b.HasKey("LabId", "ProfessorID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("LabProfessors");
                });

            modelBuilder.Entity("EclassBackend.Models.LabStudents", b =>
                {
                    b.Property<int>("LabId")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("LabId", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("LabStudents");
                });

            modelBuilder.Entity("EclassBackend.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessorID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProfessorID");

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

                    b.Property<int?>("LabId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("hasThesis")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("LabId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LabProfessor", b =>
                {
                    b.Property<int>("LabsLabId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorsProfessorID")
                        .HasColumnType("int");

                    b.HasKey("LabsLabId", "ProfessorsProfessorID");

                    b.HasIndex("ProfessorsProfessorID");

                    b.ToTable("LabProfessor");
                });

            modelBuilder.Entity("CourseProfessor", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsProfessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
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

            modelBuilder.Entity("EclassBackend.Models.CourseProfessors", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EclassBackend.Models.CourseStudents", b =>
                {
                    b.HasOne("EclassBackend.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EclassBackend.Models.LabProfessors", b =>
                {
                    b.HasOne("EclassBackend.Models.Lab", "Lab")
                        .WithMany()
                        .HasForeignKey("LabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lab");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EclassBackend.Models.LabStudents", b =>
                {
                    b.HasOne("EclassBackend.Models.Lab", "Lab")
                        .WithMany()
                        .HasForeignKey("LabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lab");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EclassBackend.Models.Student", b =>
                {
                    b.HasOne("EclassBackend.Models.Lab", null)
                        .WithMany("Students")
                        .HasForeignKey("LabId");
                });

            modelBuilder.Entity("LabProfessor", b =>
                {
                    b.HasOne("EclassBackend.Models.Lab", null)
                        .WithMany()
                        .HasForeignKey("LabsLabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EclassBackend.Models.Professor", null)
                        .WithMany()
                        .HasForeignKey("ProfessorsProfessorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EclassBackend.Models.Lab", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
