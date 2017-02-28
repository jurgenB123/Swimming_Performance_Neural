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
        public double Summation(double vjl, int k, double summation2)
        {
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += vjl * summation2;
            }

            return sum;
        }

        //Used in Hornik et al. Summation 2
        public double Summation(double wij, double n, double[] u, double Oi)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += wij * u[i] - Oi;
            }

            return sum;

        }
    }
}
