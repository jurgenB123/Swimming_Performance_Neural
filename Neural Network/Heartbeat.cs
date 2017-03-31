using System;
using DataStore;
using Helpers;
namespace Neural_Network
{

    public class Heartbeat
    {
        public const String PATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Repositories\Neural Networks\Swimming Performance Neural\WriteTest.txt";
        public static void Main()
        {
            Net_Calculation_Hornik netCalculations = new Net_Calculation_Hornik();
            Training_and_Performance activationCalculations = new Training_and_Performance();
            Weight_Initialization_Nyugen_Widrow weights = new Weight_Initialization_Nyugen_Widrow();
            DataSets_FINA dataClass = new DataSets_FINA();
            WriteTextFile save = new WriteTextFile();
            ArrayHelper helper = new ArrayHelper();

            //Predefine Console Presets
            new ConsoleController().ChangeColor(ConsoleColor.Red);

            //Generate Data 
            //Using the Data Sets
            SwimmerRecordDto[] dataSet = dataClass.GetDataSets();
            double[] finaSet = new double[dataSet.Length];
            Console.WriteLine("Sample data length: " + dataSet.Length);

            #region Get the FINA Points from each Dto
            for (int i = 0; i < dataSet.Length; i++)
            {
                finaSet[i] = dataSet[i].FinaPoints;
                Console.WriteLine("FINA: " + finaSet[i]);
            }

            Console.WriteLine("Set Length: " + finaSet.Length);
            #endregion

            #region Initialize Parameters
            //Define parameters
            const int NUMBEROFHIDDENUNITS = 3;
            const String SAVEPATH = @"C:\Users\user\Desktop\Running and Calories Thesis\Results\NeuralNetworkResults.txt";
            double net = 0;
            double y_Estimate = 0;
            double y_Actual = finaSet[0];
            double activation = activationCalculations.Train(finaSet.Length, y_Estimate, y_Actual);
            const int TRAININGDURATION = 50; //Train the NN x amount of times (specified) 
            double[] results = new double[TRAININGDURATION]; 
            #endregion

            #region Generate Weights and Biases
            //double firstWeight = weights.InitializeWeightScheme(-0.5,1);
            //double secondWeight = weights.InitializeWeightScheme(-0.5,1);
            double firstWeight = 1;
            double secondWeight = -1;
            double firstBias = 10;
            double secondBias = 10; 
            #endregion

            #region Logging Initial Variables and Presets
            //Loggin For Variables
            Console.WriteLine("First Weight: " + firstWeight);
            Console.WriteLine("Second Weight: " + secondWeight);
            Console.WriteLine("First Bias: " + firstBias);
            Console.WriteLine("Second Bias: " + secondBias);
            Console.WriteLine("Initial Net: " + net);
            Console.WriteLine("Neural Network will train for " + TRAININGDURATION + " times");
            #endregion


            #region Prepare File for New Run
            save.clearFile(SAVEPATH); 
            #endregion          

            #region Calculate the Initial Net and Activation

            net = netCalculations.Net(activation, NUMBEROFHIDDENUNITS, firstWeight, secondWeight, firstBias, secondBias, finaSet);
            activation = activationCalculations.Train(finaSet.Length, y_Estimate, y_Actual);

            Console.WriteLine("Initial Net Value: " + net);
            Console.WriteLine("Initial Activation Value: " + activation);
            new ConsoleController().ChangeColor(ConsoleColor.White);

            #endregion

            //Training an Epoch
            for (int x = 0; x < TRAININGDURATION; x++)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Training Round: " + x);

                #region Neural Network - Feed Forward
                //Training the set 
                for (int j = 0; j < dataSet.Length; j++)
                {
                    #region Set The y_Estimate and y_Actual to be the net and FINA Points in current iteration
                    y_Estimate = net;
                    y_Actual = finaSet[j];
                    #endregion

                    #region Calculate the Net (Hornik's Method)
                    net = netCalculations.Net(activation, NUMBEROFHIDDENUNITS, firstWeight, secondWeight, firstBias, secondBias, finaSet);
                    #endregion

                    #region Calculate the Activation
                    activation = activationCalculations.Train(finaSet.Length, y_Estimate, y_Actual);
                    #endregion


                    #region Populate the array for the Neural Network's Epoch and output result to console 
                    results[j] = activation;
                    Console.WriteLine("Net: " + net + " Activation: " + activation);
                    #endregion
                }

                #region Neural Network - Back Propagation
                finaSet = results; //Assign the newly obtained results into the finaSet  
                #endregion

                #region Save the Current Epoch to File, Clean the Results array for a new Epoch
                save.writeToFile(SAVEPATH, results, "Run " + x);
                save.writeToFile(SAVEPATH, "\r\n \r\n", ""); //White-space beautification
                helper.clearArray(results);
                #endregion
            }
            #endregion


            #region Alert user that Neural Network has finished
            new ConsoleController().ChangeColor(ConsoleColor.Green);
            Console.WriteLine("Finished ... ");

            #endregion
            new ConsoleController().FreezeConsole(); 
        }
    }
}
