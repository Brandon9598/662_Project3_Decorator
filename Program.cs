using System;

namespace _657_Project3_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect TV type
            int type = collectTVType();

            // Collect Resolution color
            int resolution;
            if (type != 2)
                resolution = collectResolution();
            else
                resolution = 0;

            // Smart TV
            int smart = collectSmartOption();
            
            // Pick object
            TV consumerChoice = orderCustomTV(type, resolution, smart);

            consumerChoice.Cost();
            consumerChoice.Features();

            Console.Read();
        }

        private static int collectTVType()
        {
            bool isProperAnswer = false;
            int tvType = 0;
            while (!isProperAnswer)
            {
                Console.WriteLine("What types of TV are you looking for? Please type any of the numbers for the following options");
                Console.WriteLine("1) Monitor");
                Console.WriteLine("2) Projector");
                Console.WriteLine("3) Flatscreen");
                
                if(Int32.TryParse(Console.ReadLine(), out tvType))
                {
                    if(tvType == 1 || tvType == 2 || tvType == 3)
                        isProperAnswer = true;
                }
                else
                {
                    Console.WriteLine("Incorrect answer...");
                    Console.WriteLine("What types of TV are you looking for?");
                    Console.WriteLine("1) Monitor");
                    Console.WriteLine("2) Projector");
                    Console.WriteLine("3) Flatscreen");
                }
            }
            return tvType;
        }

        private static int collectResolution()
        {
            int resolutionType = 0;
            bool isProperAnswer = false;
            while (!isProperAnswer)
            {
                Console.WriteLine("What screen resolution are you looking for? Please type any of the numbers for the following options");
                Console.WriteLine("1) OLED");
                Console.WriteLine("2) Plasma");
                Console.WriteLine("3) LCD");

                if (Int32.TryParse(Console.ReadLine(), out resolutionType))
                {
                    if (resolutionType == 1 || resolutionType == 2 || resolutionType == 3)
                        isProperAnswer = true;
                }
                else
                {
                    Console.WriteLine("Incorrect answer...");
                    Console.WriteLine("What screen resolution are you looking for? Please type any of the numbers for the following options");
                    Console.WriteLine("1) OLED");
                    Console.WriteLine("2) Plasma");
                    Console.WriteLine("3) LCD");
                }
            }
            return resolutionType;
        }

        private static int collectSmartOption()
        {
            int smartType = 0;
            bool isProperAnswer = false;
            while (!isProperAnswer)
            {
                Console.WriteLine("Do you want a smart TV? Please type any of the numbers for the following options");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");

                if (Int32.TryParse(Console.ReadLine(), out smartType))
                {
                    if (smartType == 1 || smartType == 2 )
                        isProperAnswer = true;
                }
                else
                {
                    Console.WriteLine("Incorrect answer...");
                    Console.WriteLine("Do you want a smart TV? Please type any of the numbers for the following options");
                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");
                }
            }
            return smartType;
        }

        private static TV orderCustomTV(int type, int resolution, int smart)
        {
            TV CustomTV;
            if(type == 1)
            {
                if(resolution == 1)
                {
                    if(smart == 1)
                    {
                        CustomTV = new MonitorOLEDSmart();
                    }
                    else
                    {
                        CustomTV = new MonitorOLEDDumb();
                    }
                }
                else if (resolution == 2){
                    if (smart == 1)
                    {
                        CustomTV = new MonitorPlasmaSmart();
                    }
                    else
                    {
                        CustomTV = new MonitorPlasmaDumb();
                    }
                }
                else
                {
                    if (smart == 1)
                    {
                        CustomTV = new MonitorLCDSmart();
                    }
                    else
                    {
                        CustomTV = new MonitorLCDDumb();
                    }
                }
            }
            else if(type == 2)
            {
                if(smart == 1)
                {
                    CustomTV = new ProjectorSmart();
                }
                else
                {
                    CustomTV = new ProjectorDumb();
                }
            }
            else
            {
                if (resolution == 1)
                {
                    if (smart == 1)
                    {
                        CustomTV = new FlatScreenOLEDSmart();
                    }
                    else
                    {
                        CustomTV = new FlatScreenOLEDDumb();
                    }
                }
                else if (resolution == 2)
                {
                    if (smart == 1)
                    {
                        CustomTV = new FlatScreenPlasmaSmart();
                    }
                    else
                    {
                        CustomTV = new FlatScreenPlasmaDumb();
                    }
                }
                else
                {
                    if (smart == 1)
                    {
                        CustomTV = new FlatScreenLCDSmart();
                    }
                    else
                    {
                        CustomTV = new FlatScreenLCDDumb();
                    }
                }
            }
            
            return CustomTV;
        }
    }
}
