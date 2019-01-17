using System;

namespace ConsoleUI
{
    enum State
    {
        Stopped,
        Paused,
        Running
    }

    public class UI
    { 
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

        public void PrintSplash()
        {
            Console.WriteLine(splashText);
        }

        public void SetSplash(string new_splash)
        {
            splashText = new_splash;
        }

        public string GetSplash()
        {
            return splashText;
        }

        public void StartLoop()
        {
            currentState = State.Running;
            while (currentState == State.Running)
            {
                Console.WriteLine("Hello World!");
            }
        }

        State currentState;
        string splashText;
    }

}
