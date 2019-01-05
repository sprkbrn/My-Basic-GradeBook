using System;
using System.Collections.Generic;

namespace GradeBook
{
    // Subject class - Represents a single class subject
    // Contains:
    //      (string) name
    //      (float) score
    //
    // Overrides:
    //      ToString

    public class Subject
    {
        // init
        public Subject()
        {
            SetName(" ");
            SetScore(0.0f);
            scoreRank = InitRank();
        }

        public Subject(string s_name)
        {
            SetName(s_name);
            SetScore(0.0f);
            scoreRank = InitRank();
        }

        public Subject(float f_score)
        {
            SetName(" ");
            SetScore(f_score);
            scoreRank = InitRank();
        }

        public Subject(string s_name, float f_score)
        {
            SetName(s_name);
            SetScore(f_score);
            scoreRank = InitRank();
        }

        // Methods
        public void SetName(string s_name)
        {
            // input cannot be empty
            if (s_name.Length == 1 && String.Equals(s_name, " ") || s_name.Length < 1)
            {
                // set a default name
                name = "N/A";
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

        public void SetScore(float f_score)
        {
            // score must be greater than 0.0
            if (f_score > 0.0f)
            {
                score = f_score;
            }
            else
            {
                score = 0.0f;
            }
        }
        
        public float GetScore()
        {
            return score;
        }

        // Convert the score into a letter grade
        public string GetLetterScore()
        {
            // ranking must have valid entries
            if(scoreRank.Count > 0)
            {
                // iterate through each entry
                foreach (KeyValuePair<string,float> rank in scoreRank)
                {
                    // check if the current score is greater than or equal to our sample
                    if (GetScore() > rank.Value || rank.Value.Equals(GetScore()))
                    {
                        //return the key if true
                        return rank.Key;
                    }
                }

                return "-";
            }
            else
            {
                return "-";
            }
        }

        // Init the ranking dict
        private Dictionary<string,float> InitRank()
        {
            Dictionary<string, float> rank = new Dictionary<string, float>();
            rank.Add("A", 90.0f);
            rank.Add("B", 75.0f);
            rank.Add("C", 55.0f);
            rank.Add("D", 40.0f);
            rank.Add("F", 0.0f);
            return rank;
        }

        // Overrides
        override public string ToString()
        {
            string result = "{ Subject: " + GetName() + ", Grade: " + GetLetterScore() + " }";
            return result;
        }

        // Data
        private string name;
        private float score;
        private Dictionary<String, float> scoreRank;
    }
}
