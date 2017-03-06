using System;
namespace Neural_Network
{
    class Heartbeat
    {
        public const String PATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Repositories\Neural Networks\Swimming Performance Neural\WriteTest.txt";
        public static void Main()
        {
            Net_Calculation_Hornik net = new Net_Calculation_Hornik();
            Training_and_Performance activation = new Training_and_Performance();
            Weight_Initialization weights = new Weight_Initialization();

            //Step 1: Generate Random Weights (InitializeWeightScheme)

            //Step 2: Net Calculation Hornik

            //Step 3: Activation Function (TrainingAndPerformance)

            //Step 4: Save Automation to file
            
            //Using the Data Sets
            DataSets sets = new DataSets();
            Console.WriteLine(sets.amaSam_ds4.Time);

            Console.WriteLine(activation.Train(2, 5, 10));
            new ConsoleController().FreezeConsole();
        }
    }
}
