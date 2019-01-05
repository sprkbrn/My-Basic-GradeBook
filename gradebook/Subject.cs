using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    // Subject class - Represents a single class subject
    // Contains:
    //           (string) name
    //           (float) score
    public class Subject
    {
        // init
        public Subject()
        {
            setName(" ");
            setScore(0.0f);
        }

        public Subject(string s_name)
        {
            setName(s_name);
            setScore(0.0f);
        }

        public Subject(float f_score)
        {
            setName(" ");
            setScore(f_score);
        }

        public Subject(string s_name, float f_score)
        {
            setName(s_name);
            setScore(f_score);
        }

        // Methods
        public void setName(string s_name)
        {
            // input cannot be empty
            if (s_name.Length == 1 && String.Equals(s_name, " ") || s_name.Length < 1)
            {
                // set a default name
                Name = "N/A";
            }
            else
            {
                Name = s_name;
            }
        }

        public string getName()
        {
            return Name;
        }

        public void setScore(float f_score)
        {
            // score must be greater than 0.0
            if (f_score > 0.0f)
            {
                Score = f_score;
            }
            else
            {
                Score = 0.0f;
            }
        }
        
        public float getScore()
        {
            return Score;
        }

        override public string ToString()
        {
            string result = "{ Subject: " + getName() + ", Score: " + getScore() + " }";
            return result;
        }

        // Data
        private string Name;
        private float Score;
    }
}
