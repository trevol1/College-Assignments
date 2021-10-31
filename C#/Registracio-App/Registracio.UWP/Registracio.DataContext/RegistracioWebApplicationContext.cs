using Microsoft.EntityFrameworkCore;
using Registracio.Model.Models;
using Registracio.WebApplication.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace Registracio.WebApplication.Controllers
{
    public class RegistracioWebApplicationContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Item> Items { get; set; }

        public RegistracioWebApplicationContext(DbContextOptions<RegistracioWebApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .HasKey(sc => new { sc.EmpID, sc.EmpName });


        }
    }

}