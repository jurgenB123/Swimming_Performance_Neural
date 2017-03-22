
namespace Helpers
{
    public class ArrayHelper
    {
        public double[] clearArray(double[] array)
        {
            double[] cleanedArray = new double[array.Length];
            for(int i=0; i<array.Length; i++)
            {
                cleanedArray[i] = -1;
            }

            return cleanedArray;
        }
    }
}
