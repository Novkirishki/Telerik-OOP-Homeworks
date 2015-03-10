using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        static GSM IPhone4S = new GSM("Iphone 4S", "Apple", 520, "LiPo", 200, 8, 3.5f, 16000000);

        //constructors
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 0;
            this.owner = "";
            this.battery = new Battery();
            this.display = new Display();
        }

        public GSM(string model, string manufacturer, float price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = "";
            this.battery = new Battery();
            this.display = new Display();
        }

        public GSM(string model, string manufacturer, float price, string batteryModel,
            ushort hoursIdle, byte hoursTalk, float displaySize, int numberOfColours)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = "";
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            this.display = new Display(displaySize, numberOfColours);
        }

        public GSM(string model, string manufacturer, float price, string owner, string batteryModel,
            ushort hoursIdle, byte hoursTalk, float displaySize, int numberOfColours)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk);
            this.display = new Display(displaySize, numberOfColours);
        }

        //ToString
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            string line = string.Empty;

            line = String.Format("Model: {0}", this.model);
            info.AppendLine(line);
            line = String.Format("Manufacturer: {0}", this.manufacturer);
            info.AppendLine(line);
            line = String.Format("Price: {0}", this.price);
            info.AppendLine(line);
            line = String.Format("Owner: {0}", this.owner);
            info.AppendLine(line);
            line = String.Format("Battery model: {0}", this.battery.Model);
            info.AppendLine(line);
            line = String.Format("Battery idle time: {0}", this.battery.HoursIdle);
            info.AppendLine(line);
            line = String.Format("Battery talking time: {0}", this.battery.HoursTalk);
            info.AppendLine(line);
            line = String.Format("Display size: {0}", this.display.Size);
            info.AppendLine(line);
            line = String.Format("Number of colors: {0}", this.display.NumberOfColors);
            info.AppendLine(line);

            return info.ToString();
        }

        //properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        internal Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        internal Display Display
        {
            get { return display; }
            set { display = value; }
        }
        internal static GSM IPhone4S1
        {
            get { return GSM.IPhone4S; }
            set { GSM.IPhone4S = value; }
        }
        internal List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        //managing call history
        public void AddCall(DateTime date, ulong dialedPhone, uint duration)
        {
            Call call = new Call(date, dialedPhone, duration);
            CallHistory.Add(call);
        }

        public void DeleteCall(DateTime date, ulong dialedPhone, uint duration)
        {
            Call call = new Call(date, dialedPhone, duration);
            try
            {
                CallHistory.Remove(call);
            }
            catch (Exception)
            {
                Console.WriteLine("No such call");
            }
        }

        public void DeleteCall(int index)
        {
            try
            {
                CallHistory.RemoveAt(index);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid index");
            }
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public double CalculatePrice(double costOfMinute)
        {
            double price = 0;
            foreach (Call call in callHistory)
            {
                price += Math.Ceiling((double)call.Duration / 60) * costOfMinute;
            }

            return price;
        }
    }
}
