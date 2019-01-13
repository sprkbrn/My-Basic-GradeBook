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
            id = ++ind;
            SetFirstName("John");
            SetLastName("Doe");
            classList = new List<Subject>();
        }

        public Student(string f_name)
        {
            id = ++ind;
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
            id = ++ind;
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

        public Student(string f_name, string l_name, List<Subject> subjects)
        {
            id = ++ind;
            SetFirstName(f_name);
            SetLastName(l_name);
            classList = subjects;
        }

        public Student(List<Subject> subjects)
        {
            id = ++ind;
            SetFirstName("John");
            SetLastName("Doe");
            classList = subjects;
        }

        public Student(Student student)
        {
            id = ++ind;
            SetFirstName(student.GetFirstName());
            SetLastName(student.GetLastName());
            classList = student.GetAllSubjects();
        }

        public Student(Subject subject)
        {
            id = ++ind;
            SetFirstName("John");
            SetLastName("Doe");
            classList = new List<Subject>
            {
                subject
            };
        }

        public Student(string f_name, Subject subject)
        {
            id = ++ind;
            SetFirstName(f_name);
            SetLastName("Doe");
            classList = new List<Subject>
            {
                subject
            };
        }

        public Student(string f_name, string l_name, Subject subject)
        {
            id = ++ind;
            SetFirstName(f_name);
            SetLastName(l_name);
            classList = new List<Subject>
            {
                subject
            };
        }

        // methods
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
        public void AddSubject(string sub_name, float score)
        {
            classList.Add(new Subject(sub_name, score));
        }

        // add a subject to the player class list; given a subject
        public void AddSubject(Subject new_sub)
        {
            classList.Add(new_sub);
        }

        // retrieve the class by its name reference
        public Subject GetSubjectByName(string sub_name)
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
        public List<Subject> GetAllSubjects()
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

        // modify the subject
        public void EditSubject(string name, string new_name)
        {
            Subject grade = GetSubjectByName(name);
            grade.SetName(new_name);
        }

        public void EditSubject(string name, float new_score)
        {
            Subject grade = GetSubjectByName(name);
            grade.SetScore(new_score);
        }

        public void EditSubject(string name, string new_name, float new_score)
        {
            Subject grade = GetSubjectByName(name);
            grade.SetName(new_name);
            grade.SetScore(new_score);
        }

        // remove the subjects
        public Boolean DropSubject(string name)
        {
            Subject grade = GetSubjectByName(name);

            if (classList.Contains(grade) == true)
            {
                try
                {
                    classList.Remove(grade);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        // retrieve only the highest grade
        public Subject GetHighestGradedSubject()
        {
            Subject highest_grade = new Subject();

            // ensure the class list isn't empty
            if (GetAllSubjects().Count > 0)
            {
                // ensure there is more than 1 class to compare
                if (GetAllSubjects().Count > 1)
                {
                    // iterate through each class
                    foreach (Subject this_grade in GetAllSubjects())
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

        // retrieve only the lowest grade
        public Subject GetLowestGradedSubject()
        {
            // ensure class list isn't empty
            if (GetAllSubjects().Count > 0)
            {
                // initial lowest is the first grade
                Subject lowest_grade = classList[0];

                // ensure there is more than 1 class to compare
                if (GetAllSubjects().Count > 1)
                {
                    // iterate through each class
                    foreach (Subject this_grade in GetAllSubjects())
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
        
        // overrides
        override public string ToString()
        {
            string result = "";

            result += "Name: " + GetFullName() + "\tID: " + id + "\n";

            if (classList.Count > 0)
            {
                foreach (Subject s_class in classList)
                {
                    result += s_class + "\n";
                }
            }
            else
            {
                result += "{ Student has no assigned grades }\n";
            }

            return result;
        }

        // data
        static int ind = 0;
        private int id;
        private string firstName;
        private string lastName;
        private List<Subject> classList;
    }
}