using EclassBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace EclassBackend.DAL
{
  
        public class EclassContext : DbContext
        {
            public EclassContext(DbContextOptions<EclassContext> options)
                : base(options)
            {
            }

            public DbSet<Course> Courses{ get; set; } = null!;
            public DbSet<Lab> Labs { get; set; } = null!;
            public DbSet<Professor> Professors { get; set; } = null!;

            public DbSet<Student> Students { get; set; } = null!;

            public DbSet<CourseProfessors> CourseProfessors { get; set; } = null!;
            public DbSet<CourseStudents> CourseStudents { get; set; } = null!;
            public DbSet<LabProfessors> LabProfessors{ get; set; } = null!;
            public DbSet<LabStudents> LabStudents { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseProfessors>().HasKey(cp => new { cp.CourseId, cp.ProfessorID});
            modelBuilder.Entity<CourseStudents>().HasKey(cs => new { cs.CourseId, cs.StudentID });
            modelBuilder.Entity<LabProfessors>().HasKey(lp => new { lp.LabId,lp.ProfessorID });
            modelBuilder.Entity<LabStudents>().HasKey(ls => new { ls.LabId,ls.StudentID });

        }
    }
    
}
