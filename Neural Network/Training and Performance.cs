namespace Neural_Network
{
    class Training_and_Performance
    {
        /*
        * N = Number of Data Samples
        * y_Estimate = estimate value of Neural Network
        * y_Actual = actual value of Neural Network
        */
        public double train(double N, double y_Estimate, double y_Actual)
        {
            //Ref. to Sigma Summation Method 2 for Squaring of Summation result
            return 1 / (2 * N) * (new Sigma().Summation(N, y_Estimate, y_Actual));
        }
    }
}
