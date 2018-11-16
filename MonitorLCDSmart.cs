using System;

namespace _657_Project3_Decorator
{
    class MonitorLCDSmart : TV
    {
        public override void Cost()
        {
            Console.WriteLine("Cost: \n$800.00");
        }

        public override void Features()
        {
            Console.WriteLine("TV Features: \nScreen Type:  LCD\nSmart TV Enabled");
        }
    }
}
