using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Department
    {
        Instructor Head;
        DateTime StartTime;
        DateTime EndTime;
        List<Instructor> instructors;
        List<Course> courses;
        
        public Department(Instructor head, DateTime startTime, DateTime endTime)
        {
            Head = head;
            StartTime = startTime;
            EndTime = endTime;
            instructors = new List<Instructor>();
            courses = new List<Course>();
        }

        public void AddCourse(Course c)
        {
            courses.Add(c);
        }

        public void RemoveCourse(Course c)
        {
            if (courses.Contains(c))
            {
                courses.Remove(c);
            } else
            {
                Console.WriteLine($"Cannot remove Course {c}");
            }
        }

        public void AddInstructor(Instructor i)
        {
            instructors.Add(i);
        }

        public void RemoveInstructor(Instructor i)
        {
            if (instructors.Contains(i))
            {
                instructors.Remove(i);
            }
            else
            {
                Console.WriteLine($"Cannot remove Instructor{i}");
            }
        }

    }
}
