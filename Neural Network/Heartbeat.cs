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
            DataSets_FINA dataClass = new DataSets_FINA();
            WriteTextFile save = new WriteTextFile();
            ArrayHelper helper = new ArrayHelper();

            //Predefine Console Presets
            new ConsoleController().ChangeColor(ConsoleColor.Green);

            //Generate Data 
            //Using the Data Sets
            SwimmerRecordDto[] dataSet = dataClass.GetDataSets();
            double[] finaSet = new double[dataSet.Length];
            Console.WriteLine("Sample data length: " + dataSet.Length);

            //Define parameters
            const int NUMBEROFHIDDENUNITS = 3;
            const String PATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Database Archives\Training.txt";
            const double E = Math.E;
            double net = 0;
            double y_Estimate = 1;
            double y_Actual = finaSet[0];
            double activation = activationCalculations.Train(finaSet.Length, y_Estimate, y_Actual);
            const int TRAININGDURATION = 50; //Train the NN x amount of times (specified) 
            double[] results = new double[TRAININGDURATION];
            //Step 0: Save dataSets
            //SwimmerRecordDto[] sets = { dataSets.adrianaAlbergrid_ds01, dataSets.adrianaAlbergrid_ds02 };

            //Step 1: Generate Random Weights (InitializeWeightScheme) -- CHECK METHOD IMPLEMENTATION
            double firstWeight = weights.InitializeWeightScheme(0.5, 1);
            double secondWeight = weights.InitializeWeightScheme(0.5, 1);
            double firstBias = 1;
            double secondBias = 1;

            //Clear File for a new set entry
            save.clearFile(PATH);

            //Get the FINA Points from each Dto
            for (int i = 0; i < dataSet.Length; i++)
            {
                finaSet[i] = dataSet[i].FinaPoints;
            }

            //Step 2: Net Calculation Hornik
            net = netCalculations.Net(activation, NUMBEROFHIDDENUNITS, firstWeight, secondWeight, firstBias, secondBias, finaSet);

            //Training an Epoch
            for (int x = 0; x < TRAININGDURATION; x++)
            {
                Console.WriteLine("Training Round: " + x);

                //Training the set 
                for (int j = 0; j < dataSet.Length; j++)
                {
                    y_Estimate = net;
                    y_Actual = finaSet[j];
                    net = netCalculations.Net(activation, NUMBEROFHIDDENUNITS, firstWeight, secondWeight, firstBias, secondBias, finaSet);
                    activation = activationCalculations.Train(finaSet.Length, y_Estimate, y_Actual);
                    results[j] = Math.Round(activation);

                    Console.WriteLine("Net: " + net + " Activation: " + activation);
                }

                save.writeToFile(@"C:\Users\user\Desktop\Running and Calories Thesis\Database Archives\Training.txt", results, "Run " + x);
                save.writeToFile(PATH, "\r\n \r\n", ""); //White-space beautification
                helper.clearArray(results); //Clean array for new Epoch
            }

            //Step 4: Save Automation to file
            Console.WriteLine("Finished ... ");

            new ConsoleController().FreezeConsole();
        }
    }
}
