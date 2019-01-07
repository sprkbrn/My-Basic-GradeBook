using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Student
    {
        // empty init
        public Student()
        {
            SetName(" ", " ");
            classes = new List<Subject>();
        }

        // Methods
        public void SetName(string f_name)
        {
            SetFirstName(f_name);
        }

        public void SetName(string f_name, string l_name)
        {
            SetFirstName(f_name);
            SetLastName(l_name);
        }

        private void SetFirstName(string s_name)
        {
            // name cannot be empty
            if (s_name.Equals("") || s_name.Equals(" "))
            {
                firstName = "John";
            }
            else
            {
                firstName = s_name;
            }
        }

        private void SetLastName(string s_name)
        {
            // name cannot be empty
            if (s_name.Equals("") || s_name.Equals(" "))
            {
                lastName = "Doe";
            }
            else
            {
                lastName = s_name;
            }
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public void AddClass(string sub_name, float score)
        {
            classes.Add(new Subject(sub_name, score));
        }

        // retrieve the class by its name reference
        public Subject GetGradeByClassName(string sub_name)
        {
            foreach (Subject record in classes)
            {
                if (record.GetName() == sub_name)
                {
                    return record;
                }
            }

            return new Subject(" ", 0.0f);
        }

        // retreieve all the classes
        public List<Subject> GetAllGrades()
        {
            List<Subject> results = new List<Subject>();

            if (classes.Count > 0)
            {
                foreach (Subject record in classes)
                {
                    results.Add(record);
                }
            }

            return results;
        }

        public Subject GetHighestGrade()
        {
            Subject highest_grade = new Subject();

            if (GetAllGrades().Count > 0)
            {
                if (GetAllGrades().Count > 1)
                {
                    foreach (Subject this_grade in GetAllGrades())
                    {
                        if (this_grade.GetScore() > highest_grade.GetScore())
                        {
                            highest_grade = this_grade;
                        }
                    }
                }
            }
            else
            {
                highest_grade = new Subject("N/A");
            }

            return highest_grade;
        }

        public Subject GetLowestGrade()
        {
            if (GetAllGrades().Count > 0)
            {
                Subject lowest_grade = classes[0];

                if (GetAllGrades().Count > 1)
                {
                    foreach (Subject this_grade in GetAllGrades())
                    {
                        if (lowest_grade.GetScore() > this_grade.GetScore())
                        {
                            lowest_grade = this_grade;
                        }
                    }
                }

                return lowest_grade;
            }
            else
            {
                return new Subject();
            }
        }

        // data
        private string firstName;
        private string lastName;
        private List<Subject> classes;
    }
}