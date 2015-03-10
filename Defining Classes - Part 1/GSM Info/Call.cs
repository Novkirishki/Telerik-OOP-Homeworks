using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class Call
    {
        private DateTime date;
        private ulong dialedPhone;
        private uint duration;

        //constructor
        public Call(DateTime date, ulong dialedPhone, uint duration)
        {
            this.date = date;
            this.dialedPhone = dialedPhone;
            this.duration = duration;
        }

        //properties
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public ulong DialedPhone
        {
            get { return dialedPhone; }
            set { dialedPhone = value; }
        }
        public uint Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            string line = string.Empty;

            line = String.Format("Date and time: {0}", this.Date);
            info.AppendLine(line);
            line = String.Format("Number: {0}", this.DialedPhone);
            info.AppendLine(line);
            line = String.Format("Duration: {0}s", this.Duration);
            info.AppendLine(line);            

            return info.ToString();
        }
    }
}
