using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Clock clock = new Clock();
            Display display = new Display();
            clock.ClockRunningEventHandler += new EventHandler<Clock.ClockEventArgs>(Display.PrintTime);
            clock.ClockRunningEventHandler += new EventHandler<Clock.ClockEventArgs>(FileLogger.Log);
            var task = new Task(new Action(clock.RunClock));
            task.Start();
            Console.WriteLine("Press Enter to stop watch");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                clock.StopClock = true;
            }
            Console.ReadKey();
        }
    }
}
