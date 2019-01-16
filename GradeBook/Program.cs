using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book classOfAvengers = new Book();
            Student spiderman = new Student("Peter", "Parker", new Subject("Math", 80.3f));
            Student ironman = new Student("Tony", "Stark", new Subject("Math", 78f));
            Student hulk = new Student("Bruce", "Banner", new Subject("Math", 92.7f));

            classOfAvengers.AddStudent(spiderman);
            classOfAvengers.AddStudent(ironman);
            classOfAvengers.AddStudent(hulk);

            Book.PrintStudents(classOfAvengers);
            Console.WriteLine("The class average is: {0:F1}/100", classOfAvengers.GetAverage());
        }
    }
}