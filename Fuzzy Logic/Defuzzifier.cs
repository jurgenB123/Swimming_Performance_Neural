using System;
using Helpers;

namespace Fuzzy_Logic
{
    public class Defuzzifier
    {
        //Weighting for each Infered Result
        public enum Resultant { POOR = 100, FAIR = 200, GOOD = 300, VERY_GOOD = 400, EXCELLENT = 400, INVALID = -1 };

        public int GetLinguisiticValue(Fuzzifier.Linguistic linguistic)
        {
            if (linguistic.ToString() == Resultant.POOR.ToString())
            {
                return (int)Resultant.POOR;
            }
            else if (linguistic.ToString() == Resultant.FAIR.ToString())
            {
                return (int)Resultant.FAIR;
            }
            else if (linguistic.ToString() == Resultant.GOOD.ToString())
            {
                return (int)Resultant.GOOD;
            }
            else if (linguistic.ToString() == Resultant.VERY_GOOD.ToString())
            {
                return (int)Resultant.VERY_GOOD;
            }
            else if (linguistic.ToString() == Resultant.EXCELLENT.ToString())
            {
                return (int)Resultant.EXCELLENT;
            }
            else if (linguistic.ToString() == Resultant.INVALID.ToString())
            {
                return (int)Resultant.INVALID;
            }
            else throw new Exception("Defuzzification: Something went wrong with the Resultant ...");
        }

        public double GetCentreOfGravity(int[] resultant, double[] FINA)
        {
            Sigma sigma = new Sigma();

            int resultantSigma = sigma.Summation(resultant);
            double finaSigma = sigma.Summation(FINA);

            return (resultantSigma * FINA[0]) / (resultantSigma);
        }
    }

}