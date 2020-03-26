using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class FileLogger
    {
        private static int counter = 0;
 
        public static void Log(object sender, Clock.ClockEventArgs e)
        {
            counter++;
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine("Update {0}: Tid = H{1}, M{2}, S{3}",counter, e.CurrentTime.Hour, e.CurrentTime.Minute, e.CurrentTime.Second);
            }   
        }
    }
}
