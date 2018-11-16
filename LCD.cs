using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class LCD : TV
    {
        TV tv;
        public LCD(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 25;
        }

        public override string Features()
        {
            return tv.featureList + "\nLCD";
        }
    }
}
