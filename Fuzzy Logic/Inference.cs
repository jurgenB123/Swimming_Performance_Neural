using System;

namespace Fuzzy_Logic
{
    public class Inference
    {
        //Deciding points 
        public Fuzzifier.Score ConvertFINAToLinguistic(double FINA)
        {
            Fuzzifier fuzzify = new Fuzzifier();
            if ((FINA >= 0) && (FINA < 200))
            {
                return Fuzzifier.Score.POOR;
            }
            else if ((FINA >= 200) && (FINA < 400))
            {
                return Fuzzifier.Score.FAIR;
            }
            else if ((FINA >= 400) && (FINA < 600))
            {
                return Fuzzifier.Score.GOOD;
            }
            else if ((FINA >= 600) && (FINA < 800))
            {
                return Fuzzifier.Score.VERY_GOOD;
            }
            else if ((FINA >= 800) && (FINA <= 1000))
            {
                return Fuzzifier.Score.EXCELLENT;
            }
            else
            {
                return Fuzzifier.Score.INVALID;
            }

        }
    }
}
