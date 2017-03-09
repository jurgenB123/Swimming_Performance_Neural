using System;

namespace Neural_Network
{
    class Sigma
    {
        //Generic Summation of a number
        public double Summation(double num)
        {
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += i;
            }

            return sum;
        }

        //Used in Training and Performance 
        public double Summation(double N, double y_Estimate, double y_Actual)
        {
            double sum = 0;
            for (int k = 0; k < N; k++)
            {
                sum += Math.Pow((y_Estimate - y_Actual), 2);
            }

            return sum;
        }

        //Used in Hornik et al. Summation 1
        public double Summation(double weight, int numberOfHiddenNeurons, double summation2)
        {
            double sum = 0;
            for (int i = 0; i < numberOfHiddenNeurons; i++)
            {
                sum += weight * summation2;
            }

            return sum;
        }

        //Used in Hornik et al. Summation 2
        // n --> renamed to numberOfDataSamples
        public double Summation(double weight, double numberOfDataSamples, double[] dataArray, double firstBias)
        {
            double sum = 0;
            for (int i = 0; i < numberOfDataSamples; i++)
            {
                sum += weight * dataArray[i] - firstBias;
            }

            return sum;

        }
    }
}
