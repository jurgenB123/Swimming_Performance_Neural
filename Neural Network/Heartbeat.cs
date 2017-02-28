using System;
namespace Neural_Network
{
    class Heartbeat
    {
        public const String PATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Repositories\Neural Networks\Swimming Performance Neural\WriteTest.txt";
        public static void Main()
        {

            //Console.WriteLine("Starting Neural Network Heartbeat");
            //Console.WriteLine("Writing to File ...");

            //double[] test = { 1, 2, 3, 4, 5, 6 };
            //new WriteTextFile().writeToFile(PATH, test, "Blowing up this file ... ");

            //Console.WriteLine("Write Finished.");
            //Console.ReadLine();

            Console.WriteLine(new Training_and_Performance().Train(2, 5, 10));
            new ConsoleController().FreezeConsole();
        }
    }
}
