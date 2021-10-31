using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Registracio.Model;
using Microsoft.EntityFrameworkCore.Design;

namespace Registracio.DataContext
{


    public class RegistracioApiContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Items> Items { get; set; }

        public RegistracioApiContext(DbContextOptions<RegistracioApiContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().HasData(new Employees() { EmpID = 1, EmpName = "Tony Stark"  });
            modelBuilder.Entity<Employees>().HasData(new Employees() { EmpID = 2, EmpName = "Trevo Ledrick" });
            modelBuilder.Entity<Items>().HasData(new Items() { ItemID = 1, ItemName = "Milk" });
            modelBuilder.Entity<Items>().HasData(new Items() { ItemID = 2, ItemName = "Cheese" });
        }

    }

    public class RegistracioApiContextFactory : IDesignTimeDbContextFactory<RegistracioApiContext>
    {
        public RegistracioApiContext CreateDbContext(string[] args)
        {
            var connection = @"Data Source = Donau.hiof.no; Initial Catalog = trevol; User ID = trevol; Password = rTKd47Vt;" ;

            var optionsBuilder = new DbContextOptionsBuilder<RegistracioApiContext>();
            optionsBuilder.UseSqlServer(connection, x => x.MigrationsAssembly("SchoolSolution.DataContext"));

            return new RegistracioApiContext(optionsBuilder.Options);
        }
    }

}
