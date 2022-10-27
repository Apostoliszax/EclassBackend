using EclassBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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

            


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Course>()
                .HasMany(c => c.Professors)
                .WithMany(c => c.Courses)
                .UsingEntity(j => j.ToTable("CourseProfessors"));

            modelBuilder
                .Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(c => c.Courses)
                .UsingEntity(j => j.ToTable("CourseStudents"));

        }
    }
    
}
