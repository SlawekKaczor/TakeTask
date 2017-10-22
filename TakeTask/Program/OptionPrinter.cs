using System;
using System.Collections.Generic;
using System.Text;

namespace TakeTask
{
    public static class OptionPrinter
    {
        public const string ADD_TASK_COMMAND_NAME = "a";
        public const string DISPLAY_ALL_TASKS_COMMAND_NAME = "d";
        public const string REMOVE_TASK_COMMAND_NAME = "r";
        public const string LOAD_TASK_COMMAND_NAME = "l";
        public const string SAVE_TASK_COMMAND_NAME = "s";
        public const string EXIT_COMMAND_NAME = "e";

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to TakeTask 1.0");
        }
        
        public static void PrintOptions()
        {
            Console.WriteLine("Please choose one from the following options: ");
            Console.WriteLine($"\"{ADD_TASK_COMMAND_NAME}\" " +
                $" to add a new new task to task list");
            Console.WriteLine($"\"{DISPLAY_ALL_TASKS_COMMAND_NAME}\" " +
                $" to display all tasks from the task list");
            Console.WriteLine($"\"{REMOVE_TASK_COMMAND_NAME}\" " +
                $" to remove task from the task list");
            Console.WriteLine($"\"{LOAD_TASK_COMMAND_NAME}\" " +
                $" to load tasks from the file or a database");
            Console.WriteLine($"\"{SAVE_TASK_COMMAND_NAME}\" " +
                $" to save tasks to the file or a database");
            Console.WriteLine($"\"{EXIT_COMMAND_NAME}\" to exit the program");
        }

    }
}
