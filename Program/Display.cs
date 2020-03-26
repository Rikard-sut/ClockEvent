using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Display
    {
        public static void PrintTime(object source, Clock.ClockEventArgs e)
        {
            Clock clock = (Clock)source;
            Console.Clear();
            Console.WriteLine("Logging to file, CurrentTime = {0}:{1}:{2}", e.CurrentTime.Hour, e.CurrentTime.Minute, e.CurrentTime.Second);
        }
    }
}
