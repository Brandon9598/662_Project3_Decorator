using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class MonitorLCDDumb : TV
    {
        public override void Cost()
        {
            Console.WriteLine("Cost: \n$875.00");
        }

        public override void Features()
        {
            Console.WriteLine("TV Features: \nScreen Type:  LCD");
        }
    }
}
