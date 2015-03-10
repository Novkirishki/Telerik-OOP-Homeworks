using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class GSMCallHistoryTest
    {
        public GSMCallHistoryTest() { }

        public void Test()
        {
            //create instance of GMS
            GSM phone = new GSM("Galaxy S5", "Samsung");

            //add calls
            Console.WriteLine("Enter calls info:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter date and time (dd/mm/yy HH:mm:ss)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter dialed number");
                ulong number = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Enter duration");
                uint duration = uint.Parse(Console.ReadLine());

                phone.AddCall(date, number, duration);
            }

            //print calls info
            Console.WriteLine("Calls info:");

            foreach (Call call in phone.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            //calculate calls price
            Console.WriteLine("Total price of calls: {0}", phone.CalculatePrice(0.37));

            //remove longest call and show price
            //find call with longest duration
            int index = 0;
            uint maxDuration = 0;
            int counter = 0;
            foreach (Call call in phone.CallHistory)
            {
                if (maxDuration < call.Duration)
                {
                    maxDuration = call.Duration;
                    index = counter;
                }
                counter++;
            }

            //romeve this call
            phone.DeleteCall(index);

            //calculate calls price again
            Console.WriteLine("Total price of calls after removing longest call: {0}", phone.CalculatePrice(0.37));

            //clear call history and print it
            phone.ClearCallHistory();

            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
