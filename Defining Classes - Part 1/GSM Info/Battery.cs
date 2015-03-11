using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class Battery
    {
        private string model;
        private ushort hoursIdle;
        private byte hoursTalk;
        private enum BatteryType {None, LiIon, NiMH, NiCd, LiPo};

        //constructors
        public Battery()
        {
            this.model = "";
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }

        public Battery(string model, ushort hoursIdle, byte hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        //properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public ushort HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
        public byte HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
    }
}
