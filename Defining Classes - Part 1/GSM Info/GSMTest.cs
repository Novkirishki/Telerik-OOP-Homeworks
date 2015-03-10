using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class GSMTest
    {
        public GSMTest() { }

        public void Test()
        {
            GSM[] mobilePhones = new GSM[3];

            Console.WriteLine("Input phone model");
            string model = Console.ReadLine();
            Console.WriteLine("Input phone manufacturer");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Input phone price");
            float price = float.Parse(Console.ReadLine());

            //test constructors
            mobilePhones[0] = new GSM("G2", "LG", 510, "LiPo", 900, 17, 5.2f, 16000000);
            mobilePhones[1] = new GSM("Iphone 6", "Apple", 1300, "Stoyan", "LiPo", 250, 15, 4.7f, 16000000);
            GSM phone = new GSM(model, manufacturer);
            //test properties
            phone.Price = price;

            mobilePhones[2] = phone;

            foreach (var item in mobilePhones)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(GSM.IPhone4S1.ToString());

        }
    }
}
