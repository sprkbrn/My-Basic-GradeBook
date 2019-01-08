using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Student class - Represents a single student
    // Contains:
    //      (string) firstName
    //      (string) lastName
    //
  
    public class Student
    {
        // init
        public Student()
        {
            SetFirstName("John");
            SetLastName("Doe");
            classList = new List<Subject>();
        }

        public Student(string f_name)
        {
            if (f_name == " " || f_name == "")
            {
                SetFirstName("John");
            }
            else
            {
                SetFirstName(f_name);
            }

            SetLastName("Doe");
            classList = new List<Subject>();
        }

        public Student(string f_name, string l_name)
        {
            if (f_name == " " || f_name == "")
            {
                SetFirstName("John");
            }
            else
            {
                SetFirstName(f_name);
            }

            if (l_name == " " || l_name == "")
            {
                SetLastName("Doe");
            }
            else
            {
                SetLastName(l_name);
            }
            classList = new List<Subject>();
        }

        public Student(string f_name, string l_name, List<Subject> class_list)
        {
            SetFirstName(f_name);
            SetLastName(l_name);
            classList = class_list;
        }

        // Methods
        public void SetFirstName(string s_name)
        {
            firstName = s_name;
        }

        public void SetLastName(string s_name)
        {
            lastName = s_name;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }
        
        public string GetLastName()
        {
            return lastName;
        }

        // add a subject to the player class list; given the name and score
        public void AddClass(string sub_name, float score)
        {
            classList.Add(new Subject(sub_name, score));
        }

        // add a subject to the player class list; given a subject
        public void AddClass(Subject new_sub)
        {
            classList.Add(new_sub);
        }

        // retrieve the class by its name reference
        public Subject GetGradeByClassName(string sub_name)
        {
            foreach (Subject record in classList)
            {
                if (record.GetName() == sub_name)
                {
                    return record;
                }
            }

            return new Subject(" ", 0.0f);
        }

        // retreieve all items the class list
        public List<Subject> GetAllClasses()
        {
            List<Subject> results = new List<Subject>();

            if (classList.Count > 0)
            {
                foreach (Subject record in classList)
                {
                    results.Add(record);
                }
            }

            return results;
        }

        // retrieve only the highest grade
        public Subject GetHighestGrade()
        {
            Subject highest_grade = new Subject();

            // ensure the class list isn't empty
            if (GetAllClasses().Count > 0)
            {
                // ensure there is more than 1 class to compare
                if (GetAllClasses().Count > 1)
                {
                    // iterate through each class
                    foreach (Subject this_grade in GetAllClasses())
                    {
                        if (this_grade.GetScore() > highest_grade.GetScore())
                        {
                            // retreieve the largest
                            highest_grade = this_grade;
                        }
                    }
                }
            }
            else
            {
                // if the list is empty, return an empty subject
                highest_grade = new Subject("N/A");
            }

            return highest_grade;
        }

        // only the lowest grade
        public Subject GetLowestGrade()
        {
            // ensure class list isn't empty
            if (GetAllClasses().Count > 0)
            {
                // initial lowest is the first grade
                Subject lowest_grade = classList[0];

                // ensure there is more than 1 class to compare
                if (GetAllClasses().Count > 1)
                {
                    // iterate through each class
                    foreach (Subject this_grade in GetAllClasses())
                    {
                        if (lowest_grade.GetScore() > this_grade.GetScore())
                        {
                            // retrieve only the lowest grade
                            lowest_grade = this_grade;
                        }
                    }
                }

                return lowest_grade;
            }
            else
            {
                // if the list is empty return an empty Subject
                return new Subject("N/A");
            }
        }

        // data
        private string firstName;
        private string lastName;
        private List<Subject> classList;
    }
}