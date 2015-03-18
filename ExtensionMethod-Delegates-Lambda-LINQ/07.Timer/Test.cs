//Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    class Test
    {      
        static int MethodToBeExecuted()
        {
            Console.WriteLine("I am a method that is invoked at a specified interval");
            return 1;
        }
        static void Main(string[] args)
        {

            Timer timer = new Timer(2); //time interval in seconds
            timer.Execute(MethodToBeExecuted); 
          
        }
    }
}
