using System;
using System.Collections.Generic;
using System.Text;

namespace TakeTask
{
    public static class CommandExecutor
    {
        public static void AddTask()
        {
            Console.WriteLine("This is AddTask method");
        }

        public static void DisplayAllTasks()
        {
            Console.WriteLine("This is DisplayAllTasksMethod method");
        }

        public static void RemoveTask()
        {
            Console.WriteLine("This is RemoveTask method");
        }

        public static void LoadTask()
        {
            Console.WriteLine("This is LoadTask method");
        }

        public static void SaveTask()
        {
            Console.WriteLine("This is SaveTask method");
        }

        public static void ExitProgram()
        {
            Console.WriteLine("This is ExitProgram method");
            //Environment.Exit(0);
        }
    }
}
