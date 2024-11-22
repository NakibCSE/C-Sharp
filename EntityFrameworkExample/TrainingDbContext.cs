using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString = "Server=DESKTOP-O70O0UG\\SQLEXPRESS;Database=CSharpB18;User Id=CSharpB18;Password=12345;Trust Server Certificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollment>().HasKey((x) => new { x.CourseId, x.StudentId});
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");
            modelBuilder.Entity<Course>().Property(x => x.Title).HasMaxLength(50);
            //For one to one
            modelBuilder.Entity<Course>()
                .HasMany(x => x.Topics)
                .WithOne(y => y.Course)
                .HasForeignKey(z => z.CourseID);

            //For many to many
            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(x => x.course)
                .WithMany(y => y.MyCourses)
                .HasForeignKey(z => z.CourseId);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(x => x.student)
                .WithMany(y => y.CourseStuddents)
                .HasForeignKey(z => z.StudentId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
