using System;
using System.Collections.Generic;

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

            my_grades.AddStudent(new Student("Susan", "Powers"));
            my_grades.AddStudent(new Student("Scott", "Pillgrim"));

            Student Stretch = new Student("Richard", "Reed");
            Stretch.AddClass("Math", 90.5f);

            my_grades.AddStudent(Stretch);

            Console.WriteLine(my_grades);

            //List<Student> stud = new List<Student>();

            //Student Frank = new Student("Frank", "Castle");
            //Frank.AddClass("Economics", 55.3f);
            //stud.Add(Frank);

            //Student Peter = new Student("Peter", "Parker");
            //Peter.AddClass("Chemistry", 90f);
            //stud.Add(Peter);

            //Student Freeman = new Student("Frank", "Freeman");
            //Freeman.AddClass("Physics", 82.3f);
            //stud.Add(Freeman);

            //printStudents(stud);
            //Console.WriteLine("-------------");

            //Predicate<Student> predicate = FindPred;
            //bool FindPred(Student person)
            //{
            //    return person.GetFirstName() == "Frank";
            //}

            //Student result = stud.Find(FindPred);

            //result = new Student("Richard", "Price");

            //printStudents(stud);

            //Console.WriteLine(Frank);
        }

        static public void printStudents(List<Student> l_students)
        {
            foreach (Student s in l_students)
            {
                Console.WriteLine(s);
            }
        }
    }
}