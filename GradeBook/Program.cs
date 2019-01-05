using System;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> my_classes = new List<Subject>();
            my_classes.Add(new Subject("Math", 55.2f));
            my_classes.Add(new Subject("Eng", 90.7f));
            my_classes.Add(new Subject("Sci", 75.2f));


            foreach (Subject sub_class in my_classes)
            {
                Console.WriteLine(sub_class);
            }

        }
    }
}
