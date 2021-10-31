using System.Linq;
using Microsoft.EntityFrameworkCore;
using Registracio.Model;
using Registracio.WebApplication.Models;

namespace Registracio.WebApplication.Controllers
{
    public class RegistracioWebApplicationContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }

        public RegistracioWebApplicationContext(DbContextOptions<RegistracioWebApplicationContext> options) : base(options) { }

        
        
    }

}