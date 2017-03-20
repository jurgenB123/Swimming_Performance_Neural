namespace Fuzzy_Logic
{
    using System;

    public class Fuzzifier
    {
        public enum Score { POOR, FAIR, GOOD, VERY_GOOD, EXCELLENT, INVALID };

        //Qualify the ENUM into meaningful strings the controller can manipulate
        public string GetResult(Score result)
        {
            if (result == Score.POOR)
            {
                return "Poor".ToUpper().ToString();
            }
            else if (result == Score.FAIR)
            {
                return "Fair".ToUpper().ToString();
            }
            else if (result == Score.GOOD)
            {
                return "Good".ToUpper().ToString();
            }
            else if (result == Score.VERY_GOOD)
            {
                return "Very Good".ToUpper().ToString();

            }
            else if (result == Score.EXCELLENT)
            {
                return "Excellent".ToUpper().ToString();
            }
            else if (result == Score.INVALID)
            {
                return "Invalid".ToUpper().ToString();
            }
            else return "Something went horribly wrong ... ".ToUpper().ToString();
        }
    }
}
