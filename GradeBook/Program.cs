using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Joe = new Student();
            Joe.SetName("Joe");

            Joe.AddClass("Science", 70f);
            Joe.AddClass("English", 62.4f);
            Joe.AddClass("Math", 54.8f);

            Console.WriteLine(Joe.GetName());
            Joe.GetAllClasses();
        }
    }
}
