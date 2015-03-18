using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08.TimerWithEvent
{
    class Timer
    {
        private int interval;
        public Timer(int interval)
        {
            this.interval = 1000 * interval;
        }

        public event EventHandler MethodInvoke;

        public void Execute()
        {
            while (true)
            {
                MethodInvoke(this, null);
                Thread.Sleep(this.interval);
            }
        }
    }
}
