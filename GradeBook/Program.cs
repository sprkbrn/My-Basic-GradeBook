using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Joe = new Student("Joe", "Camel");

            //Joe.AddClass("Science", 70f);
            //Joe.AddClass("English", 62.4f);
            //Joe.AddClass("Math", 54.8f);

            //Console.WriteLine(Joe.GetFullName());

            //foreach (Subject topic in Joe.GetAllClasses())
            //{
            //    Console.WriteLine(topic);
            //}

            //Console.WriteLine("Highest Grade: " + Joe.GetHighestGrade());
            //Console.WriteLine("Lowest Grade: " + Joe.GetLowestGrade());

            GradeBook my_grades = new GradeBook();

            Console.WriteLine(my_grades.name);
        }
    }
}