using System;
using Helpers;
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
            
            string DIRECTORY = Properties.Settings.Default.FolderPath;
            string SAVEPATH = Properties.Settings.Default.FilePath;

            #region Create Save Directory
            System.IO.Directory.CreateDirectory(DIRECTORY); 
            #endregion

            // Get Datasets for Individuals
            #region Get the whole dataset of each Athlete
            SwimmerRecordDto[] DanekSheppard = data.GetDanekSheppard();
            SwimmerRecordDto[] AdrianaAlbergrid = data.GetAdrianaAlbergrid();
            SwimmerRecordDto[] BrianaGerrig = data.GetBrianaGerrig();
            SwimmerRecordDto[] JanellaTinker = data.GetJanellaTinker();
            SwimmerRecordDto[] JennieZhang = data.GetJenniZhang();
            #endregion

            #region Obtain all points for each participant             
            double[] DanekSheppard_FINA = new double[DanekSheppard.Length];
            for (int a1 = 0; a1 < DanekSheppard.Length; a1++)
            {
                DanekSheppard_FINA[a1] = DanekSheppard[a1].FinaPoints;
            }

            double[] AdrianaAlbergrid_FINA = new double[AdrianaAlbergrid.Length];
            for (int a2 = 0; a2 < AdrianaAlbergrid.Length; a2++)
            {
                AdrianaAlbergrid_FINA[a2] = AdrianaAlbergrid[a2].FinaPoints;
            }

            double[] BrianaGerrig_FINA = new double[BrianaGerrig.Length];
            for (int a3 = 0; a3 < BrianaGerrig.Length; a3++)
            {
                BrianaGerrig_FINA[a3] = BrianaGerrig[a3].FinaPoints;
            }

            double[] JanellaTinker_FINA = new double[JanellaTinker.Length];
            for (int a4 = 0; a4 < JanellaTinker.Length; a4++)
            {
                JanellaTinker_FINA[a4] = JanellaTinker[a4].FinaPoints;
            }

            double[] JennieZhang_FINA = new double[JennieZhang.Length];
            for (int a5 = 0; a5 < JennieZhang.Length; a5++)
            {
                JennieZhang_FINA[a5] = JennieZhang[a5].FinaPoints;
            }
            #endregion

            #region Step 1: Fuzzify all data into Linguisic Variables for each athlete    

            Fuzzifier.Linguistic[] DanekSheppard_Linguistic_Set = new Fuzzifier.Linguistic[DanekSheppard_FINA.Length];
            for (int b = 0; b < DanekSheppard_Linguistic_Set.Length; b++)
            {
                DanekSheppard_Linguistic_Set[b] = inference.ConvertFINAToLinguistic(DanekSheppard_FINA[b]);
            }

            Fuzzifier.Linguistic[] AdrianaAlbergrid_Linguistic_Set = new Fuzzifier.Linguistic[AdrianaAlbergrid_FINA.Length];
            for (int b1 = 0; b1 < AdrianaAlbergrid_Linguistic_Set.Length; b1++)
            {
                AdrianaAlbergrid_Linguistic_Set[b1] = inference.ConvertFINAToLinguistic(AdrianaAlbergrid_FINA[b1]);
            }

            Fuzzifier.Linguistic[] BrianaGerrig_Linguistic_Set = new Fuzzifier.Linguistic[BrianaGerrig_FINA.Length];
            for (int b2 = 0; b2 < BrianaGerrig_Linguistic_Set.Length; b2++)
            {
                BrianaGerrig_Linguistic_Set[b2] = inference.ConvertFINAToLinguistic(BrianaGerrig_FINA[b2]);
            }

            Fuzzifier.Linguistic[] JanellaTinker_Linguistic_Set = new Fuzzifier.Linguistic[JanellaTinker_FINA.Length];
            for (int b3 = 0; b3 < JanellaTinker_Linguistic_Set.Length; b3++)
            {
                JanellaTinker_Linguistic_Set[b3] = inference.ConvertFINAToLinguistic(JanellaTinker_FINA[b3]);
            }

            Fuzzifier.Linguistic[] JenniZhang_Linguistic_Set = new Fuzzifier.Linguistic[JennieZhang_FINA.Length];
            for (int b4 = 0; b4 < JenniZhang_Linguistic_Set.Length; b4++)
            {
                JenniZhang_Linguistic_Set[b4] = inference.ConvertFINAToLinguistic(JennieZhang_FINA[b4]);
            }

            #endregion



            #region Step 2: Generate the Fuzzy Output (NOTE: Rules working during fuzzification under the hood )

            string[] DanekSheppard_Output_Set = new string[DanekSheppard_Linguistic_Set.Length];
            for (int c = 0; c < DanekSheppard_Output_Set.Length; c++)
            {
                DanekSheppard_Output_Set[c] = inference.ConstructOutput(DanekSheppard_Linguistic_Set[c]);
            }

            string[] AdrianaAlbergrid_Output_Set = new string[AdrianaAlbergrid_Linguistic_Set.Length];
            for (int c1 = 0; c1 < AdrianaAlbergrid_Output_Set.Length; c1++)
            {
                AdrianaAlbergrid_Output_Set[c1] = inference.ConstructOutput(AdrianaAlbergrid_Linguistic_Set[c1]);
            }

            string[] BrianaGerrig_Output_Set = new string[BrianaGerrig_Linguistic_Set.Length];
            for (int c2 = 0; c2 < BrianaGerrig_Linguistic_Set.Length; c2++)
            {
                BrianaGerrig_Output_Set[c2] = inference.ConstructOutput(BrianaGerrig_Linguistic_Set[c2]);
            }

            string[] JanellaTinker_Output_Set = new string[JanellaTinker_Linguistic_Set.Length];
            for (int c3 = 0; c3 < JanellaTinker_Output_Set.Length; c3++)
            {
                JanellaTinker_Output_Set[c3] = inference.ConstructOutput(JanellaTinker_Linguistic_Set[c3]);
            }

            string[] JennieZhang_Output_Set = new string[JenniZhang_Linguistic_Set.Length];
            for (int c4 = 0; c4 < JennieZhang_Output_Set.Length; c4++)
            {
                JennieZhang_Output_Set[c4] = inference.ConstructOutput(JenniZhang_Linguistic_Set[c4]);
            }
            #endregion


            #region Step 3: Defuzzify Data to Generate Quantifiable Meanings            
            int[] DanekSheppard_Defuzzified_Set = new int[DanekSheppard_Linguistic_Set.Length];
            for (int d = 0; d < DanekSheppard_Output_Set.Length; d++)
            {
                DanekSheppard_Defuzzified_Set[d] = defuzz.GetLinguisiticValue(DanekSheppard_Linguistic_Set[d]);
            }

            int[] AdrianaAlbergrid_Defuzzified_Set = new int[AdrianaAlbergrid_Linguistic_Set.Length];
            for (int d1 = 0; d1 < AdrianaAlbergrid_Defuzzified_Set.Length; d1++)
            {
                AdrianaAlbergrid_Defuzzified_Set[d1] = defuzz.GetLinguisiticValue(AdrianaAlbergrid_Linguistic_Set[d1]);
            }

            int[] BrianaGerrig_Defuzzified_Set = new int[BrianaGerrig_Linguistic_Set.Length];
            for (int d2 = 0; d2 < BrianaGerrig_Defuzzified_Set.Length; d2++)
            {
                BrianaGerrig_Defuzzified_Set[d2] = defuzz.GetLinguisiticValue(BrianaGerrig_Linguistic_Set[d2]);
            }

            int[] JanellaTinker_Defuzzified_Set = new int[JanellaTinker_Linguistic_Set.Length];
            for (int d3 = 0; d3 < JanellaTinker_Defuzzified_Set.Length; d3++)
            {
                JanellaTinker_Defuzzified_Set[d3] = defuzz.GetLinguisiticValue(JanellaTinker_Linguistic_Set[d3]);
            }

            int[] JennieZhang_Defuzzified_Set = new int[JenniZhang_Linguistic_Set.Length];
            for (int d4 = 0; d4 < JennieZhang_Output_Set.Length; d4++)
            {
                JennieZhang_Defuzzified_Set[d4] = defuzz.GetLinguisiticValue(JenniZhang_Linguistic_Set[d4]);
            }
            #endregion

            #region Step 4: Pass Defuzzied data through checker to generate final results on how the athlete did -- Change functionality per athlete 
            var DanekSheppard_Result = defuzz.GetCentreOfGravity(DanekSheppard_Defuzzified_Set, DanekSheppard_FINA);
            var AdrianaAlbergrid_Result = defuzz.GetCentreOfGravity(AdrianaAlbergrid_Defuzzified_Set, AdrianaAlbergrid_FINA);
            var BrianaGerrig_Result = defuzz.GetCentreOfGravity(BrianaGerrig_Defuzzified_Set, BrianaGerrig_FINA);
            var JanellaTinker_Result = defuzz.GetCentreOfGravity(JanellaTinker_Defuzzified_Set, JanellaTinker_FINA);
            var JennieZhang_Result = defuzz.GetCentreOfGravity(JennieZhang_Defuzzified_Set, JennieZhang_FINA);
            #endregion

            #region Print Results to Screen

            Console.WriteLine("Final Result of Danek Sheppard: " + DanekSheppard_Result);
            Console.WriteLine("Final Result of Adriana Albergrid: " + AdrianaAlbergrid_Result);
            Console.WriteLine("Final Result of Briana Gerrig: " + BrianaGerrig_Result);
            Console.WriteLine("Final Result of Janella Tinker: " + JanellaTinker_Result);
            Console.WriteLine("Final Result of Jennie Zhang: " + JennieZhang_Result);

            string[] finalResult = new string[] {"\r\n"+
                "Final Result of Participant 1: " + DanekSheppard_Result +"\r\n",
                "Final Result of Participant 2: " + AdrianaAlbergrid_Result +"\r\n",
                "Final Result of Participant 3: " + BrianaGerrig_Result+"\r\n",
                "Final Result of Participant 4: " + JanellaTinker_Result+"\r\n",
                "Final Result of Participant 5: " + JennieZhang_Result +"\r\n"};


            #endregion

            #region Save Results to File
            WriteTextFile save = new WriteTextFile();
            save.clearFile(SAVEPATH);
            save.writeToFile(SAVEPATH, finalResult, "");
            #endregion


            Console.ReadLine();

        }
    }
}
