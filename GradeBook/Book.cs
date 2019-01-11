using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        public Book()
        {
            roster = new List<Student>();
        }

        public Book(List<Student> students)
        {
            roster = students;
        }

        // methods
        public void AddStudent(string name)
        {
            Student pupil = new Student(name);
        }

        public void AddStudent(string f_name, string l_name)
        {
            Student pupil = new Student(f_name, l_name);
        }

        public void AddStudent(Student s_pupil)
        {
            roster.Add(s_pupil);
        }

        public List<Student> GetStudentRoster()
        {
            if (roster.Count > 0)
            {
                return roster;
            }
            else
            {
                return new List<Student>();
            }
        }

        private string BookAsString()
        {
            string result = "";
            int iter = 0;
            if (roster.Count > 0)
            {
                foreach (Student pupil in roster)
                {
                    iter += 1;
                    result += pupil;
                    if (roster.Count != iter)
                    {
                        result += "\n";
                    }
                }
            }
            else
            {
                string error_string = "No records available.";
                return error_string;
            }

            return result;
        }

        // static methods
        static public void PrintStudents(Book grades)
        {
          Console.WriteLine(grades);
        }

        static public void PrintStudents(List<Student> students)
        {
            if (students.Count > 0)
            {
                foreach (Student pupil in students)
                {
                    Console.WriteLine(pupil);
                }
            }
            else
            {
                Console.WriteLine("No records available.");
            }

        }

        // overrides
        override public string ToString()
        {
            return BookAsString();
        }

        // data
        private List<Student> roster;
    }
}
