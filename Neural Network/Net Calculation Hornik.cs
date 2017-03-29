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

        public double Net(double activationFunctionResult, int numberOfHiddenNeurons, double firstWeight, double secondWeight, double firstBias, double secondBias, double[] dataArray)
        {
            Sigma sigma = new Sigma();
            double dataSetResult = 1;
            for(int i=0; i<dataArray.Length; i++) dataSetResult *= dataArray[i]; //Multiply all the content of the dataArray

            double innerSummationMath = secondWeight * dataSetResult * firstBias;
            double innerSummation = sigma.Summation(innerSummationMath);

            double outerSummationMath = firstWeight * activationFunctionResult * innerSummation;
            double outerSummation = sigma.Summation(outerSummationMath);

            return outerSummation;
        }
    }
}
