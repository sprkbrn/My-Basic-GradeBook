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

        // overrides
        override public string ToString()
        {
            string result = "";
            int student_count = 1;

            foreach (Student pupil in roster)
            {
                result += student_count + ". Name: " + pupil.GetFullName() + "\n";

                if (pupil.GetAllSubjects().Count > 0)
                {
                    foreach (Subject grade in pupil.GetAllSubjects())
                    {
                        result += "\t" + grade + "\n";
                    }
                }
                else
                {
                    result += "\t{ This student has no assigned grades }\n";
                }

                student_count += 1;
            }

            return result;
        }

        // data
        private List<Student> roster;
    }
}
