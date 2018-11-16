using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class Flatscreen : TVTypeDecorator
    {
        TV tv;
        public Flatscreen(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 200;
        }

        public override string Features()
        {
            return tv.featureList + "\nFlatscreen";
        }
    }

}
