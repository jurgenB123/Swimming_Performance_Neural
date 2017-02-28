namespace Neural_Network
{
    class Sigma
    {
        public double Summation(double num)
        {
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
