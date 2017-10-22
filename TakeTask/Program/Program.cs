using System;
using TakeTask;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //intrastructure setup
            //execute na executorze
                //Resolve command - zdecyduj co zrobic i zwroc to akcje
                //command() - wykonaj akcje

            Setup.Configure();
            Executor.Execute();
            Console.ReadKey();
            // koniec programu
        }
    }
}
