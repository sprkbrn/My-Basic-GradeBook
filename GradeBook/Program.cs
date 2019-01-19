using System;
using GradeBook.Interface;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string splash_text = @"
GradeBook Application
------------------------------------
This application will assist in managing your students
and grading ruberick. Get to know who is struggling
and who is doing great all at a glance.";

            UI userInterface = new UI();
            userInterface.SetSplash(splash_text);
            userInterface.PrintSplash();
            Console.Write("\n\n");

            Book roster = new Book();
            Student spiderman = new Student("Peter", "Parker", new Subject("Math", 80.3f));
            Student ironman = new Student("Tony", "Stark", new Subject("Math", 78f));
            Student hulk = new Student("Bruce", "Banner", new Subject("Math", 92.7f));

            roster.AddStudent(spiderman);
            roster.AddStudent(ironman);
            roster.AddStudent(hulk);

            userInterface.StartLoop(roster);
        }
    }
}