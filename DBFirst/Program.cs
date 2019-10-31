using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new PlutoEntities();
            dbContext.GetAuthorCourses(null);
            var courses = dbContext.GetCourses();
            courses.ToList().ForEach(c => Console.WriteLine(c.Title));
            var course = new Course
            {
                Level = CourseLevel.Beginner
            };
        }
    }
}
