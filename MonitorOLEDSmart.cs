using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class MonitorOLEDSmart : TV
    {
        public override void Cost()
        {
            Console.WriteLine("Cost: \n$1100.00");
        }

        public override void Features()
        {
            Console.WriteLine("TV Features: \nScreen Type: 4K \nSmart TV Enabled");
        }
    }
}
