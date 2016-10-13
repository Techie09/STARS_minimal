using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STARS_minimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth += 60;
            //load all students
            var students = JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText("Students.json")); 

            //select a student
            students.ForEach(s1 => Console.WriteLine(s1.FirstName));
            string input = String.Empty;

            while (string.IsNullOrEmpty(input) || !students.Any(s2 => s2.FirstName.ToLower().Contains(input.ToLower())))
            {
                Console.WriteLine("Enter a student name view details: ");
                input = Console.ReadLine();
            }
            //display student
            Student s = students.FirstOrDefault(student => student.FirstName.ToLower().Contains(input.ToLower()));
            Console.WriteLine("StudentID: " + s.StudentID);
            Console.WriteLine("     Name: " + s.FirstName + " " + s.LastName);
            s.Courses.ForEach(c => Console.WriteLine(String.Format("Course: [CourseID]{0,7} [CourseName]{1,15} [CourseType]{2,10} [Credit]{3,1} [Semester]{4,6} [Year]{5,4} [Grade]{6,10}", c.CourseID,c.CourseName,c.CourseType,c.Credit,c.Semester,c.Year,c.Grade)));

            Console.ReadKey(true);
        }

        public class Student
        {
            public string StudentID, FirstName, LastName;
            public List<Course> Courses = new List<Course>();
        }

        public class Course
        {
            public string CourseID, CourseNumber, CourseName, CourseType, Credit, Semester, Year, Grade;
        }
    }
}
