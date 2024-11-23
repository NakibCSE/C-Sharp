using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun1
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.UseSqlServer("Data Source=DESKTOP-O70O0UG\\SQLEXPRESS;Initial Catalog=CSharpB18;User ID=csharpb18;Password=123456;TrustServerCertificate=True;"); }
    }
}
