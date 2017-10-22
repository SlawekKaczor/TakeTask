using System;

namespace TakeTask
{
    public static class CommandResolver
    {
        public static Action GetCommand(Option option)
        {
            switch(option)
            {
                case Option.AddTask:
                    return CommandExecutor.AddTask;
                case Option.DisplayAllTasks:
                    return CommandExecutor.DisplayAllTasks;
                case Option.RemoveTask:
                    return CommandExecutor.RemoveTask;
                case Option.LoadAllTasks:
                    return CommandExecutor.LoadTask;
                case Option.SaveTask:
                    return CommandExecutor.SaveTask;
                case Option.ExitProgram:
                    return CommandExecutor.ExitProgram;
                default:
                    return CommandExecutor.DisplayAllTasks;
            }
        }
    }
}