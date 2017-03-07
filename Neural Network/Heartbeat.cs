using System;
namespace Neural_Network
{
    class Heartbeat
    {
        public const String PATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Repositories\Neural Networks\Swimming Performance Neural\WriteTest.txt";
        public static void Main()
        {
            Net_Calculation_Hornik netCalculations = new Net_Calculation_Hornik();
            Training_and_Performance activationCalculations = new Training_and_Performance();
            Weight_Initialization weights = new Weight_Initialization();
            DataSets_FINA dataSets = new DataSets_FINA();

            const int NUMBEROFHIDDENUNITS = 3;
            const double E = Math.E;
            double net = 0;
            double activation = 0;
            double y_Estimate = 0;
            double y_Actual = 0;

            //Step 0: Save dataSets
            //SwimmerRecordDto[] sets = { dataSets.adrianaAlbergrid_ds01, dataSets.adrianaAlbergrid_ds02 };

            //Step 1: Generate Random Weights (InitializeWeightScheme) -- CHECK METHOD IMPLEMENTATION
            double firstWeight = weights.InitializeWeightScheme(0.5, 1);
            double secondWeight = weights.InitializeWeightScheme(0.5, 1);
            double firstBias = 1;
            double secondBias = 1;



            //Step 2: Net Calculation Hornik
            //net = netCalculations.Net(activationCalculations.Train(10, y_Estimate, y_Actual), NUMBEROFHIDDENUNITS, firstWeight, secondWeight, firstBias, secondBias,);


            //Step 3: Activation Function (TrainingAndPerformance)

            //Step 4: Save Automation to file

            //Using the Data Sets
            SwimmerRecordDto[] fullSet = dataSets.GetDataSets();
            for(int i=0; i< fullSet.Length; i++)
            {
                Console.WriteLine(fullSet[i]);
            }

            new ConsoleController().FreezeConsole();
        }
    }
}
