using MaoNaMassa.ContentContext;
using System;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();
            course.Level = EContentLevel.Beginner;

            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);

        }
    }
}
