using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class GradeBook
    {
        public GradeBook()
        {
            roster = new List<Student>();
        }

        public GradeBook(List<Student> students)
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

        public Boolean testSomething()
        {
            Student reed = new Student("Richard", "Reed");
            reed.AddClass("Math", 90.5f);

            if (roster.Contains(reed) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // overrides
        override public string ToString()
        {
            string result = "";
            int student_count = 1;

            foreach (Student pupil in roster)
            {
                result += student_count + ". ";
                result += pupil + "\n";
                student_count += 1;
            }

            return result;
        }

        // data
        private List<Student> roster;
    }
}
