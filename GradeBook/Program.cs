using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Joe = new Student();
            Joe.SetName("Joe", "Lame");

            Joe.AddClass("Science", 70f);
            Joe.AddClass("English", 62.4f);
            Joe.AddClass("Math", 54.8f);

            Console.WriteLine(Joe.GetName());

            foreach (Subject topic in Joe.GetAllGrades())
            {
                Console.WriteLine(topic);
            }

            Console.WriteLine("Highest Grade: " + Joe.GetHighestGrade());
            Console.WriteLine("Lowest Grade: " + Joe.GetLowestGrade());
        }
    }
}