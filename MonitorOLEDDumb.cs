using System;
using System.Collections.Generic;
using System.Text;

namespace _657_Project3_Decorator
{
    class MonitorOLEDDumb : TV
    {
        public override void Cost()
        {
            Console.WriteLine("Cost: \n$1000.00");
        }

        public override void Features()
        {
            Console.WriteLine("TV Features: \nScreenTyp: OLED \n");
        }
    }
}
