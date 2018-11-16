using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class Projector : TVTypeDecorator
    {
        TV tv;
        public Projector(TV tv)
        {
            this.tv = tv;
        }

        public override int Cost()
        {
            return tv.cost + 400;
        }

        public override string Features()
        {
            return tv.featureList + "\nProjector";
        }
    }
}
