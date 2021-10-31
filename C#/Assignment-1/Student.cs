using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<StudentCourse> Attends { get; } = new List<StudentCourse>();
    }
}
