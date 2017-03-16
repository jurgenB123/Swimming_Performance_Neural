using System;

namespace Fuzzy_Logic
{
    public class Heartbeat
    {

        //Initialize Prerequisits
        static Rules rule = new Rules();
        static Fuzzifier fuzzy = new Fuzzifier();
        static Defuzzifier defuzz = new Defuzzifier();
        static Inference inference = new Inference();

        public static void Main()
        {
            Console.WriteLine("Hey there ..");

            var finaPoints = rule.CalculateFINAPoints(20.21, rule.CURRENTWORLDRECORD);
            Console.WriteLine("FINA : " + finaPoints);
            Console.ReadLine();
        }
    }
}
