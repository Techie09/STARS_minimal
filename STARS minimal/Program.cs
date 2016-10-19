using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace STARS_minimal
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic students = JsonConvert.DeserializeObject(File.ReadAllText("Students.json"));

            foreach (var s in students)
            {
                if (args.Count() != 0 && (s.StudentID.ToString().Contains(args[0]) || s.FirstName.ToString().Contains(args[0]) || s.LastName.ToString().Contains(args[0])))
                {
                    Console.WriteLine("\n{0}|{1} {2}",s.StudentID.ToString().Insert(1, "-").Insert(4, "-"), s.FirstName, s.LastName);
                    foreach (var c in s.Courses) Console.WriteLine(String.Format("\t|[CourseID]{0,-7} [CourseName]{1,-20} [CourseType]{2,-11} [Credit]{3,-1} [Semester]{4,-6} [Year]{5,-4} [Grade]{6,-8}", c.CourseID, c.CourseName, c.CourseType, c.Credit, c.Semester, c.Year, c.Grade));
                }
            }
        }
    }
}
