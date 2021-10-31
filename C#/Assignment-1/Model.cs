using Exercise4;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Exercise4
{
    public class Model : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                InitialCatalog = "Trevos_DB",
                IntegratedSecurity = true
            };

            optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
        }*/


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
             {
                 DataSource = "Donau.hiof.no",
                 InitialCatalog = "trevol",
                 UserID = "trevol",
                 Password = "rTKd47Vt"
             };
             optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
         }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Attends)
                .HasForeignKey(sc => sc.StudentId);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(bc => bc.CourseId);
        }
    }

}



/*public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}*/

/*public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
 
}*/
/*public class StudentCourse
{
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
}*/