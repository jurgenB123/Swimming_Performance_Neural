using System;

namespace Swimmer_Performance_Predictor
{
    public class Console_Helper
    {
        public void NeuralOrFuzzy(int value)
        {
            bool isValidOption = false;

            while (isValidOption == false)
            {
                switch (value)
                {
                    case 1:
                        isValidOption = true;
                        Neural_Network.Heartbeat.Main();
                        break;
                    case 2:
                        isValidOption = true;
                        Fuzzy_Logic.Heartbeat.Main();
                        break;
                    case 3:
                        isValidOption = true;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Option Entered Please try again...");
                        isValidOption = false;
                        break;
                }
            }

        }

        public void PrintUserInstructons()
        {
            Console.WriteLine("How to Run Project: ");
            Console.WriteLine("Press 1: Run Neural Network Training");
            Console.WriteLine("Press 2: Run Fuzzy Logic Training");
            Console.WriteLine("Press 3: Exit");
        }
    }
}
