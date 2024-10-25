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
            modelBuilder.Entity<Topic>().ToTable("Topics");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; } 
    }
}
