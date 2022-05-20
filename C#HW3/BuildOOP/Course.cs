using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Course
    {
        List<Student> students;

        public Course()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void DeleteStudent(Student s)
        {
            if (students.Contains(s))
            {
                students.Remove(s);
            } else
            {
                Console.WriteLine($"Cannot remove Student {s}");
            }
        }
    }
}
