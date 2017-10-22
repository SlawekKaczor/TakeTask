using System;
using System.Collections.Generic;
using System.Text;

namespace TakeTask
{
    public static class OptionPrinter
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to TakeTask 1.0");
        }
        
        public static void PrintOptions()
        {
            Console.WriteLine("Please choose one from the following options: ");
            Console.WriteLine("\"a\" to add a new new task to task list");
            Console.WriteLine("\"d\" to display all tasks from the task list");
            Console.WriteLine("\"r\" to remove task from the task list");
            Console.WriteLine("\"l\" to load tasks from the file or a database");
            Console.WriteLine("\"s\" to save tasks to the file or a database");
            Console.WriteLine("\"e\" to exit the program");
        }

    }
}
