using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class Plasma :TV
    {
        TV tv;
        public Plasma(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 50;
        }

        public override string Features()
        {
            return tv.featureList + "\nPlasma";
        }
    }
}
