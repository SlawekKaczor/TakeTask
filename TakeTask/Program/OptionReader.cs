using System;

namespace TakeTask
{
    public static class OptionReader
    {
        public const string ADD_TASK_COMMAND_NAME = "a";
        public const string DISPLAY_ALL_TASKS_COMMAND_NAME = "d";
        public const string REMOVE_TASK_COMMAND_NAME = "r";
        public const string LOAD_TASK_COMMAND_NAME = "l";
        public const string SAVE_TASK_COMMAND_NAME = "s";
        public const string EXIT_COMMAND_NAME = "e";

        public static Option GetOption()
        {
            Console.Write("Please choose your command: ");
            string command = Console.ReadLine();
            if (command.Equals(ADD_TASK_COMMAND_NAME)) 
            {
                return Option.AddTask;
            } 
            else if (command.Equals(DISPLAY_ALL_TASKS_COMMAND_NAME))
            {
                return Option.DisplayAllTasks;
            }
            else if (command.Equals(REMOVE_TASK_COMMAND_NAME))
            {
                return Option.RemoveTask;
            }
            else if (command.Equals(LOAD_TASK_COMMAND_NAME))
            {
                return Option.LoadAllTasks;
            }
            else if (command.Equals(SAVE_TASK_COMMAND_NAME))
            {
                return Option.SaveTask;
            }
            else if (command.Equals(EXIT_COMMAND_NAME))
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