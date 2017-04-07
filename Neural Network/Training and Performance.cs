using Helpers;
using System;

namespace Neural_Network
{
    class Training_and_Performance
    {

        /// <param name="N">Number of Data Samples</param>
        /// <param name="y_Estimate">Activation</param>
        /// <param name="y_Actual">FinaSeta[j]</param>
        /// <returns></returns>
        public double Train(int N, double y_Estimate, double y_Actual)
        {
            Sigma sigma = new Sigma();

            double outerMath = 1 / (2 * N);
            double innerMath = Math.Pow((y_Estimate - y_Actual), 2); //Square the difference
            double summation = sigma.Summation(innerMath, N);
            double finalResult = outerMath * summation;
            return finalResult;
        }
    }
}
