using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Range_Exceptions
{
    class InvalidRangeException<T> : ArgumentException
    {
        private T start;
        private T end;

        public InvalidRangeException()
            : this(null, default(T), default(T), null)
        {

        }

        public InvalidRangeException(string message) 
            : this(message, default(T), default(T), null)
        {

        }

        public InvalidRangeException(T start, T end) 
            : this(String.Format("Invalid range exception [{0}, {1}]", start, end), start, end, null)
        {

        }

        public InvalidRangeException(string message, T start, T end, Exception innerException) 
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get { return start; }
            set { start = value; }
        }

        public T End
        {
            get { return end; }
            set { end = value; }
        }
    }
}
