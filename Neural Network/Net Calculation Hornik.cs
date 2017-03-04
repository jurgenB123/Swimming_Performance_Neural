namespace Neural_Network
{
    class Net_Calculation_Hornik
    {
        /*
        * r is the activation function
        * k is the number of hidden units 
        * vjl and wij are weights 
        * Oiand Ol are polarized value (biases)
        * u is the data vector
        */
        public double Net(double activationFunctionResult, int numberOfHiddenNeurons, double firstWeight, double secondWeight, double firstBias, double secondBias, double[] dataArray)
        {
            Sigma sigma = new Sigma();
            double summation2 = activationFunctionResult * (sigma.Summation(secondWeight, numberOfHiddenNeurons, dataArray, firstBias) - secondBias);
            return sigma.Summation(firstWeight, numberOfHiddenNeurons, summation2);
        }
    }
}
