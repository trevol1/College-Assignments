using Registracio.DataContext;
using Registracio.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Registracio.Database
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Academia rules!");

            var connection = @"Data Source=Donau.hiof.no; Initial Catalog=trevol; User ID=trevol; Password=rTKd47Vt;";
            var optionsBuilder = new DbContextOptionsBuilder<RegistracioApiContext>();
            optionsBuilder.UseSqlServer(connection);

            using (var db = new RegistracioApiContext(optionsBuilder.Options))
            {
               
                Employees employee1 = new Employees()
                {
                    EmpName = "Trevo Ledrick",
                    EmpID = 1001
                };
                db.Employees.Add(employee1);

                Employees employee2 = new Employees()
                {
                    EmpName = "Tony Stark",
                    EmpID = 1004
                };
                db.Employees.Add(employee2);

                db.SaveChanges();
            }
        }

    }

}