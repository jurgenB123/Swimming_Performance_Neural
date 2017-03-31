using Helpers;
using System;

namespace Neural_Network
{
    class Training_and_Performance
    {
        /*
        * N = Number of Data Samples
        * y_Estimate = estimate value of Neural Network
        * y_Actual = actual value of Neural Network
        */
        public double Train(int numberOfDataSamples, double y_Estimate, double y_Actual)
        {
            Sigma sigma = new Sigma();

            double outerMath = 1 / (2 * numberOfDataSamples);
            double innerMath = Math.Pow((y_Estimate - y_Actual), 2); //Square the difference
            double summation = sigma.Summation(innerMath, numberOfDataSamples);
            double finalResult = outerMath * summation;
            return finalResult;

        }
    }
}
