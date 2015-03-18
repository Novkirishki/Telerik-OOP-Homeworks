using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02.Extensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(text[i]);
            }
            return result;
        }
    }
}
