using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class Monitor : TVTypeDecorator
    {
        TV tv;
        public Monitor(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 100;
        }

        public override string Features()
        {
            return tv.featureList + "\nMonitor";
        }
    }
}
