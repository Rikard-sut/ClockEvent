using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Clock
    {
        public event EventHandler<ClockEventArgs> ClockRunningEventHandler;
        public bool StopClock { get; set; } = false;
        public Clock()
        {

        }
        public void RunClock()
        {
            ClockEventArgs clockEventArgs = new ClockEventArgs(DateTime.Now);
            while (true)
            {
                clockEventArgs.CurrentTime = DateTime.Now;
                Thread.Sleep(1000);
                ClockRunningEventHandler?.Invoke(this, clockEventArgs);

                if (clockEventArgs.CancelCounting)
                {
                    break;
                }
                
            }
        }
        public class ClockEventArgs : EventArgs
        {
            public bool CancelCounting { get; set; } = false;
            public DateTime CurrentTime { get; set; }

            public ClockEventArgs(DateTime dateTime)
            {
                CurrentTime = dateTime;
            }
        }

    }
}
