using System;

namespace Fuzzy_Logic
{
    public class Inference
    {
        //Deciding points 
        public Fuzzifier.Linguistic ConvertFINAToLinguistic(double FINA)
        {
            Fuzzifier fuzzify = new Fuzzifier();
            if ((FINA >= 0) && (FINA < 200))
            {
                return Fuzzifier.Linguistic.POOR;
            }
            else if ((FINA >= 200) && (FINA < 400))
            {
                return Fuzzifier.Linguistic.FAIR;
            }
            else if ((FINA >= 400) && (FINA < 600))
            {
                return Fuzzifier.Linguistic.GOOD;
            }
            else if ((FINA >= 600) && (FINA < 800))
            {
                return Fuzzifier.Linguistic.VERY_GOOD;
            }
            else if ((FINA >= 800) && (FINA <= 1000))
            {
                return Fuzzifier.Linguistic.EXCELLENT;
            }
            else
            {
                return Fuzzifier.Linguistic.INVALID;
            }
        }

        public String ConstructOutput(Fuzzifier.Linguistic linguistic)
        {
            return "The individual scored a " + linguistic.ToString();
        }
    }
}
