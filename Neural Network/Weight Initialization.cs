﻿using System;

namespace Neural_Network
{
    public class Weight_Initialization_Nyugen_Widrow
    {
        public const double PI = Math.PI;
        public const double MAGNITUDE_CONST = 0.7;

        // Weight W ==> [ -0.5 >= x <= 0.5 ]
        public double GenerateRandomWeight(double minimum, double maximum)
        {
            return new Random().NextDouble() * (maximum - minimum) + minimum;
        }

        // Input Vector X ==> [ -1 >= x <= 1 ]
        public double GenerateRandomInput()
        {
            double maximum = -1;
            double minimum = 1;
            return new Random().NextDouble() * (maximum - minimum) + minimum;
        }

        // Centre of Interval ==> [ -Wi >= x <= Wi ]
        public double GetCentreOfInterval(double magnitude)
        {
            double minimum = -magnitude;
            double maximum = magnitude;

            return new Random().NextDouble() * (maximum - minimum) + minimum;
        }

        // S = I ^ (N-1)
        public double GenerateBias(double I, double N)
        {
            var S = Math.Pow(I, (N - 1));
            return S;
        }


        // H = S.I
        // H Nodes used to form S slices over I intervals
        public double GetNodes(double S, double I)
        {
            var H = S * I;
            return H;
        }

        // |Wi| = H ^ (1/N)
        public double GetWeightMagnitude(double w, double H, double N)
        {
            var wi = Math.Pow(H, (1 / N));
            return wi;
        }

        //d(x1, x2) = 0.5 * sin(pi * x1^2) * sin(pi * x2)
        public double InitializeWeightScheme(double x1, double x2)
        {
            return 0.5 * Math.Sin(PI * Math.Pow(x1, 2)) * Math.Sin(2 * PI * x2);
        }

    }
}
