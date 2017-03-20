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
            //Testing Rules Engine 
            var finaPoints = rule.CalculateFINAPoints(20.21, rule.CURRENTWORLDRECORD);
            Console.WriteLine("FINA : " + finaPoints);

            //Testing Inference Engine 
            Console.WriteLine("Infered 200 points into linguistic --> \t " + inference.ConvertFINAToLinguistic(200));
            Console.WriteLine("Infered 500 points into linguistic --> \t " + inference.ConvertFINAToLinguistic(500));
            Console.WriteLine("Infered 1000 points into linguistic --> \t " + inference.ConvertFINAToLinguistic(1000));
            Console.ReadLine();

        }
    }
}
