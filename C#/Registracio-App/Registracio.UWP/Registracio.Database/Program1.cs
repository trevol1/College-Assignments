using Microsoft.EntityFrameworkCore;
using Registracio.WebApplication.Controllers;
using Registracio.Database;
using Registracio.Model;
using System;
using System.Collections.Generic;
using Registracio.WebApplication.Models;

namespace Registracio.Database
{
    class Program1
    {
        //private static object db;

        static void Main(string[] args)
        {
            Console.WriteLine("Academia rules!");

            var connection = @"Data Source=Donau.hiof.no; Initial Catalog=trevol; User ID=trevol; Password=;";
            var optionsBuilder = new DbContextOptionsBuilder<RegistracioWebApplicationContext>();
            optionsBuilder.UseSqlServer(connection);

            using (var db = new RegistracioWebApplicationContext(optionsBuilder.Options))
            {
                //   db.Database.EnsureCreated();  // Quick and dirty :-)

                // fill db with some test-data
                

                Employees employee1 = new Employees()
                {
                    EmpName = "Trevo Ledrick",
                    EmpID = 1001,
                    Birthday = new DateTime(1996, 20, 6)
                };
                db.Employees.Add(employee1);

                Employees employee2 = new Employees()
                {
                    EmpName = "Tony Stark",
                    EmpID = 1004,
                    Birthday = new DateTime(1987, 2, 6)
                };
                db.Employees.Add(employee2);

                db.SaveChanges();
            }
        }

    }
    
}
