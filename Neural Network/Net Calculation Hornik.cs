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
        public double Net(double r, int k, double vjl, double wij, double Oi, double Ol, double[] u)
        {
            Sigma sigma = new Sigma();
            double summation2 = r * (sigma.Summation(wij, k, u, Oi) - Ol);
            return sigma.Summation(vjl, k, summation2);
        }

    }
}
