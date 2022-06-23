using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> HomeworkSubmissions { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity => 
                {
                    entity.Property(t => t.Name)
                        .HasMaxLength(100)
                        .IsRequired(true)
                        .IsUnicode(true);

                    entity.Property(t => t.PhoneNumber)
                        .IsFixedLength(true)
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .IsRequired(false);

                    entity.Property(t => t.Birthday)
                        .IsRequired(false);

                    entity.HasMany(x => x.CourseEnrollments);
                    entity.HasMany(x => x.HomeworkSubmissions);

                });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(t => t.Name)
                    .HasMaxLength(80)
                    .IsUnicode(true);
                
                entity.Property(t => t.Description)
                    .IsUnicode(true)
                    .IsRequired(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(t => t.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true);

                entity.Property(t => t.Url)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(t => t.Content)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });
        }
    }
}