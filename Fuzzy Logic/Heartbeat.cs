using System;

namespace Fuzzy_Logic
{
    class Heartbeat
    {

        //Initialize Prerequisits
        Rules rule = new Rules();
        Fuzzifier fuzzy = new Fuzzifier();
        Defuzzifier defuzz = new Defuzzifier();
        Inference inference = new Inference();

        public static void Main()
        {
            Console.WriteLine("Hey there ..");
            Console.ReadLine();
        }
    }
}
