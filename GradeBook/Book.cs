using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        // init
        public Book()
        {
            roster = new List<Student>();
        }

        public Book(Student student)
        {
            roster = new List<Student>();
            roster.Add(student);
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

        // retrieve the class by its name reference
        public Student GetStudentByFullName(string s_name)
        {
            foreach (Student record in roster)
            {
                if (record.GetFullName() == s_name)
                {
                    return record;
                }
            }

            return new Student("N/A");
        }

        public List<Student> GetStudentsByFirstName(string s_name)
        {
            List<Student> results = new List<Student>();

            foreach (Student record in roster)
            {
                if (record.GetFirstName() == s_name)
                {
                    results.Add(record);
                }
            }

            return results;
        }

        public List<Student> GetStudentsByLastName(string s_name)
        {
            List<Student> results = new List<Student>();

            foreach (Student record in roster)
            {
                if (record.GetLastName() == s_name)
                {
                    results.Add(record);
                }
            }

            return results;
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

        // return the contents of the book as a string
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

        public float GetAverage()
        {
            float total = 0f;
            foreach (Student pupil in roster)
            {
                total += pupil.GetAverage();
            }

            total /= roster.Count;

            return total;
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

        static public float GetAverage(List<Student> l_students)
        {
            float total = 0f;
            foreach (Student pupil in l_students)
            {
                total += pupil.GetAverage();
            }

            total /= l_students.Count;

            return total;
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
