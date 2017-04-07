using Helpers;
namespace Neural_Network
{
    public class Net_Calculation_Hornik
    {
        /*
        * r is the activation function
        * k is the number of hidden units 
        * vjl and wij are weights 
        * Oiand Ol are polarized value (biases)
        * u is the data vector
        */

        public double Net(double activation, int numberOfHiddenNeurons, double firstWeight, double secondWeight, double firstBias, double secondBias, double[] dataArray)
        {
            Sigma sigma = new Sigma();
            double innerSummationMath = 0;
            for(int i=0; i<dataArray.Length; i++) innerSummationMath += (secondWeight * dataArray[i] - firstBias); //Multiply all the content of the dataArray

            double innerSummation = sigma.Summation(innerSummationMath,dataArray.Length);

            double outerSummationMath = firstWeight * activation * innerSummation - secondBias;
            double outerSummation = sigma.Summation(outerSummationMath, numberOfHiddenNeurons);

            return outerSummation;
        }
    }
}
