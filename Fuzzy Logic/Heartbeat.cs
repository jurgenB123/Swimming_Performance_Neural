using System;
using DataStore;
namespace Fuzzy_Logic
{
    public class Heartbeat
    {

        //Initialize Prerequisits
        static Rules rule = new Rules();
        static Fuzzifier fuzzy = new Fuzzifier();
        static Defuzzifier defuzz = new Defuzzifier();
        static Inference inference = new Inference();
        static DataSets_FINA data = new DataSets_FINA();

        public static void Main()
        {
            //Testing Rules Engine 
            var finaPoints = rule.CalculateFINAPoints(20.21, rule.CURRENTWORLDRECORD);
            Console.WriteLine("FINA : " + finaPoints);

            //Testing Inference Engine             
            Console.WriteLine(inference.ConstructOutput(inference.ConvertFINAToLinguistic(200)));


            //Algorithm
            //Step 0: Construct the Data Set 
            SwimmerRecordDto[] dataSet = data.GetDataSets();
            double[] finaSet = new double[dataSet.Length];

            //Get the FINA Points from each Dto
            for (int a = 0; a < dataSet.Length; a++)
            {
                finaSet[a] = dataSet[a].FinaPoints;
            }

            //Step 1: Fuzzify all data into Linguisic Variables
            Fuzzifier.Linguistic[] linguisticSet = new Fuzzifier.Linguistic[finaSet.Length];
            for(int b =0; b<linguisticSet.Length; b++)
            {
                linguisticSet[b] = inference.ConvertFINAToLinguistic(finaSet[b]);
            }

            //Step 2: Generate the Fuzzy Output (NOTE: Rules working during fuzzification under the hood )
            string[] fuzzySet = new string[linguisticSet.Length];
            for(int c=0; c<fuzzySet.Length; c++)
            {
                fuzzySet[c] = inference.ConstructOutput(linguisticSet[c]);
            }


            //Step 3: Defuzzify Data to Generate Quantifiable Meanings
            int[] defuzziedSet = new int[linguisticSet.Length];
            for(int d =0; d<fuzzySet.Length; d++)
            {
                defuzziedSet[d] = defuzz.GetLinguisiticValue(linguisticSet[d]);
                Console.WriteLine("Fuzzy: "+fuzzySet[d]+" Result: " + defuzziedSet[d]);
            }

            //Step 4: Pass Defuzzied data through checker to generate final results on how the athlete did

            Console.ReadLine();


        }
    }
}
