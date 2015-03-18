using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TimerWithEvent
{
    class Program
    {
        static void MethodToBeExecuted(object source, EventArgs e)
        {
            Console.WriteLine("I am a method that is invoked at a specified interval");
        }
        static void Main(string[] args)
        {
            Timer timer = new Timer(2);
            timer.MethodInvoke += MethodToBeExecuted;
            timer.Execute();
        }
    }
}
