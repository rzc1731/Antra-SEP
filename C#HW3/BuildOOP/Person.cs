using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildOOP
{
    public class Person
    {
        private int BirthYear;
        protected decimal BaseSalary;
        private string[] Addresses { get; set; }

        public Person(int birthYear, decimal baseSalary, string[] addresses)
        {
            BirthYear = birthYear;
            BaseSalary = baseSalary;
            Addresses = addresses;
        }
        public int Age()
        {
            return DateTime.Now.Year - BirthYear;
        }

        public virtual decimal Salary()
        {
            return BaseSalary;
        }

    }

    public class Instructor : Person
    {
        private DateTime JoinDate;
        public Department Dp;
        public Instructor(int birthYear, decimal baseSalary, string[] addresses, DateTime joinDate, Department dp) : base(birthYear, baseSalary, addresses)
        {
            JoinDate = joinDate;
            Dp = dp;
        }

        public override decimal Salary()
        {
            return BaseSalary + (DateTime.Now.Year - JoinDate.Year) * 2000;
        }
    }

    public class Student : Person
    {
        Dictionary<Course, int> CourseGrades = new Dictionary<Course, int>();
        public Student(int birthYear, decimal baseSalary, string[] addresses) : base(birthYear, baseSalary, addresses)
        {
        }

        public float GPA()
        {
            float sum = 0;
            foreach (int grade in CourseGrades.Values)
            {
                sum = sum + grade;
            }
            return sum / (float)CourseGrades.Count;
        }

        public void AddCourse(Course c, int grade)
        {
            CourseGrades.Add(c, grade);
        }

        public void UpdateGrade(Course c, int grade)
        {
            CourseGrades[c] = grade;
        }

        public void RemoveCourse(Course c)
        {
            CourseGrades.Remove(c);
        }
    }
}
