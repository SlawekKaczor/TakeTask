using System;
using System.Collections.Generic;
using System.Text;

namespace TakeTask
{
    public static class Executor
    {
        public static void Execute()
        {
            OptionPrinter.PrintWelcomeMessage();
            
            while (true)
            {
                OptionPrinter.PrintOptions();
                var readOption = OptionReader.GetOption();
                CommandResolver.GetCommand(readOption)?.Invoke(); //simplifed if null...
            }
        }
    }
}
