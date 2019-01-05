using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Student
    {
        // init
        public Student()
        {
            name = "Jeff";
            classes = new List<Subject>();
        }

        // Methods
        public void SetName(string s_name)
        {
            // name cannot be empty
            if (s_name.Length > 0 || s_name.Equals(" "))
            {
                name = "Unidentified";
            }
            else
            {
                name = s_name;
            }
        }

        public string GetName()
        {
            return name;
        }

        public void AddClass(string sub_name, float score)
        {
            classes.Add(new Subject(sub_name, score));
        }

        public void GetClass(string sub_name)
        {
            foreach (Subject record in classes)
            {
                if (record.GetName() == sub_name)
                {
                    Console.WriteLine(record);
                }
            }
        }

        public void GetAllClasses()
        {
            foreach (Subject record in classes)
            {
                    Console.WriteLine(record);
            }
        }

        // data
        string name;
        List<Subject> classes;
    }
}