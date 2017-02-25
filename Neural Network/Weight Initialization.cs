using System;

namespace Neural_Network
{
    public class Weight_Initialization
    {
        //Returns a random weight between -0.5 and 0.5 both inclusive 
        public double GenerateRandomWeight()
        {            
            double maximum = 0.5;
            double minimum = -0.5;
            return new Random().NextDouble() * (maximum - minimum) + minimum;
        }


    }
}
