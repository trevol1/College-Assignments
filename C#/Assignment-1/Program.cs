using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{


    class Program
    {
        //private IEnumerable<Student> Student;

        static void Main(string[] args)
        {

            using (var db = new Model())
            {

                Program college_students = new Program();
                List<Student> studentsList = new List<Student>();
                Program courses_college = new Program();
                List<Course> coursesList = new List<Course>();
                Program StudentCourse = new Program();
                List<StudentCourse> StudentCourseList = new List<StudentCourse>();

                Console.Clear();
                Console.WriteLine("Welcome to Student Database");
                Console.WriteLine("1.Add new student");
                Console.WriteLine("2.View students list");
                Console.WriteLine("3.Assign student to course");
                Console.WriteLine("");
                Console.Write("Please press one no.");
                Console.WriteLine("");
                int choose_number = Convert.ToInt32(Console.ReadLine());
                switch (choose_number)
                {
                    case 1:
                        college_students.Function_Add_Student(studentsList);
                        Function_Add_Course();
                        // college_students.Function_Display_Student(studentsList);
                        break;
                    // Here i tried to set up a case to display the students who where registrered.
                    case 2:
                        Function_Read_Students();
                        break;
                    //    break;
                    case 3:
                        FunctionADDStdentCourse();
                        break;

                }
                Function_Read_Students();
                //FunctionADDStdentCourse();
                //QueryData();
                Console.WriteLine("Press a key to exit");
                Console.ReadLine();
            }
        }

        // Here i Have a function that adds Students and partially assignes Course.
        private void Function_Add_Student(List<Student> studentsList)
        {
            Console.Write("Enter students name:");
            string studentName = Console.ReadLine();

            Student student = new Student
            {
                Name = studentName
            };

            using (var db = new Model())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }


        private static void Function_Add_Course()
        {
            Console.Write("Enter course name:");
            string courseName = Console.ReadLine();
            Course courses_college1 = new Course()
            {
                CourseName = courseName
            };

            using (var db = new Model())
            {
                db.Courses.Add(courses_college1);
                db.SaveChanges();
            }
        }

        static void Function_Read_Students()
        {
            using (var db = new Model())
            {
                List<Student> allStudents = db.Students.ToListAsync().Result;

                foreach (Student student in allStudents)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
        private static void QueryData()
        {
            using (var db = new Model())
            {
                var courses = db.Courses
                    .Include(c => c.Students)
                    .ThenInclude(s => s.Student)
                    .ToList();

                foreach (var course in courses)
                {
                    //Console.WriteLine("{0}", Course.CourseName);
                    foreach (var studentCourse in course.Students)
                        Console.WriteLine("\t{0}, {1}", studentCourse.Student.Name);
                }
            }
        }


        private static void FunctionADDStdentCourse()
        {
            Console.Write("Enter Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            using (var db = new Model())
            {
                List<Student> students = db.Students.ToListAsync().Result;
                List<Course> kursene = db.Courses.ToListAsync().Result;
                Student student = (from s1 in students where s1.StudentId == studentId select s1).First() as Student;
                Course kurs = (from k1 in kursene where k1.CourseId == courseId select k1).First() as Course;

                StudentCourse studentCourse = new StudentCourse
                {
                    Course = kurs,
                    Student = student
                };

                db.StudentCourses.Add(studentCourse);
                db.SaveChanges();

            }
            
           
        }
    }
}

