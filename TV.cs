using System;

namespace _657_Project3_Decorator
{
    class TV
    {
        public string featureList = "TV Features:";
        public int cost = 500;
        public virtual string Features() {
            return featureList;
        }

        public virtual int Cost()
        {
            return cost;
        }
            
    }
}