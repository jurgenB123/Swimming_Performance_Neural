using System;
namespace Fuzzy_Logic
{

    public class Fuzzifier
    {
        public enum Linguistic { POOR, FAIR, GOOD, VERY_GOOD, EXCELLENT, INVALID };

        //Qualify the ENUM into meaningful strings the controller can manipulate
        public string GetResult(Linguistic result)
        {
            if (result == Linguistic.POOR)
            {
                return "Poor".ToUpper().ToString();
            }
            else if (result == Linguistic.FAIR)
            {
                return "Fair".ToUpper().ToString();
            }
            else if (result == Linguistic.GOOD)
            {
                return "Good".ToUpper().ToString();
            }
            else if (result == Linguistic.VERY_GOOD)
            {
                return "Very Good".ToUpper().ToString();

            }
            else if (result == Linguistic.EXCELLENT)
            {
                return "Excellent".ToUpper().ToString();
            }
            else if (result == Linguistic.INVALID)
            {
                return "Invalid".ToUpper().ToString();
            }
            else return "Something went horribly wrong ... ".ToUpper().ToString();
        }
    }
}
