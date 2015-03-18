using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.Timer
{
    delegate int Caller();
    class Timer
    {
        private int time;
        private Caller caller;

        public Timer( int time)
        {
            this.time = time * 1000;
        }

        public void Execute(Func<int> myMethodName)
        {
            caller = new Caller(myMethodName);
            while (true)
            {
                caller();
                Thread.Sleep(this.time);
            }
        }
    }
}
