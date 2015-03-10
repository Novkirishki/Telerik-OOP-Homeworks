using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM_Info
{
    class Display
    {
        private float size;
        private int numberOfColors;

        //constructors
        public Display()
        {
            this.size = 0;
            this.numberOfColors = 0;
        }

        public Display(float size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //properties
        public float Size
        {
            get { return size; }
            set { size = value; }
        }
        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}
