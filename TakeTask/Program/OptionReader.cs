using System;

namespace TakeTask
{
    public static class OptionReader
    {
        
        public static Option GetOption()
        {
            Console.Write("Please choose your command: ");
            string command = Console.ReadLine();
            if (command.Equals("a"))
            {
                return Option.AddTask;
            } 
            else if (command.Equals("d"))
            {
                return Option.DisplayAllTasks;
            }
            else if (command.Equals("r"))
            {
                return Option.RemoveTask;
            }
            else if (command.Equals("l"))
            {
                return Option.LoadAllTasks;
            }
            else if (command.Equals("s"))
            {
                return Option.SaveTask;
            }
            else if (command.Equals("e"))
            {
                return Option.ExitProgram;
            }
            else
            {
                return GetOption();
            }
        }
    }
}