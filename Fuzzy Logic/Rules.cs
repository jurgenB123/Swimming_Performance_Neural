using System;

namespace Fuzzy_Logic
{
    public class Rules
    {
        public double CURRENTWORLDRECORD = 46.91;
        //Assuming the FINA Points equation
        public double CalculateFINAPoints(double time, double currentWorldRecord)
        {
            return 1000 * Math.Pow((20.91 / currentWorldRecord), 3);
        }

        
    }
}
