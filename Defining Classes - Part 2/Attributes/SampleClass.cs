using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [Version(2, 32)]
    class SampleClass
    {
        static void Main(string[] args)
        {
            Type type = typeof(SampleClass);
            object[] attribute = type.GetCustomAttributes(false);
            Console.WriteLine("The version is {0}.{1}", ((Version)attribute[0]).Major, ((Version)attribute[0]).Minor);
        }
    }
}
