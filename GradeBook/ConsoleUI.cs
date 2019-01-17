using System;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook.Interface
{
    // current state of the loop execution
    public enum State
    {
        Stopped,
        Paused,
        Running
    }

    // type of option for user selection
    public enum OptionType
    {
        Option,
        Exit
    }

    // UI Class:
    // Represents a UI entity for allowing external manipulation
    // or viewing of the GradeBook data
    public class UI
    {
        //init
        public UI()
        {
            splashText = "The application has started";
            Console.WriteLine(splashText);
        }

        public UI(string splash)
        {
            splashText = splash;
            Console.WriteLine(splashText);
        }

        // methods
        public string GetSplash()
        {
            return splashText;
        }

        public void SetSplash(string new_splash)
        {
            splashText = new_splash;
        }

        public void PrintSplash()
        {
            Console.WriteLine(splashText);
        }

        public void StartLoop(Book current_roster)
        {
            currentState = State.Running;

            Console.WriteLine("Current Roster:\n");
            Console.Write(current_roster);
            Console.Write("\n\n");

            while (currentState == State.Running)
            {
                Dictionary<string, OptionType> options = GetOptions(current_roster);
                PrintOptions(options);
                currentState = State.Stopped;
            }

        }

        // return a dictionary of options for each given type
        public Dictionary<string, OptionType> GetOptions(Book book)
        {
            Dictionary<string, OptionType> options = new Dictionary<string, OptionType>();
            options.Add("Add a new Student", OptionType.Option);
            options.Add("View an existing Student", OptionType.Option);
            options.Add("Remove an existing Student", OptionType.Option);
            options.Add("Exit", OptionType.Exit);

            return options;
        }

        public List<string> GetOptions(Student student)
        {
            List<string> options = new List<string>();
            options.Add("Add a Subject");
            options.Add("Modify a Subject");
            options.Add("Remove a Subject");
            options.Add("Get the grade average");
            options.Add("Back");

            return options;
        }

        public List<string> GetOptions(List<Student> students)
        {
            List<string> options = new List<string>();
            options.Add("Add a new Student");
            options.Add("View an existing Student");
            options.Add("Remove an existing Student");
            options.Add("Exit");

            return options;
        }

        public List<string> GetOptions(Subject subj)
        {
            List<string> options = new List<string>();
            options.Add("Change the Subject name");
            options.Add("Modify the Student's Score");
            options.Add("Back");

            return options;
        }

        public List<string> GetOptions(List<Subject> subjects)
        {
            List<string> options = new List<string>();
            options.Add("Modify a Subject");
            options.Add("Get the grade average");
            options.Add("Back");

            return options;
        }

        // static
        static public void PrintOptions(Dictionary<string, OptionType> options)
        {
            int counter = 1;
            foreach (KeyValuePair<string, OptionType> current_option in options)
            {
                Console.WriteLine("{0}. {1}", counter, current_option.Key);
                counter++;
            }

        }

        State currentState;
        string splashText;
    }

}
