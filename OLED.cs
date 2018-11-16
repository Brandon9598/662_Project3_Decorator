using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class OLED :TV
    {
        TV tv;
        public OLED(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 75;
        }

        public override string Features()
        {
            return tv.featureList + "\nOLEd";
        }
    }
}
