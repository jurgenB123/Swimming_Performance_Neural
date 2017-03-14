using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class ArrayHelper
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
