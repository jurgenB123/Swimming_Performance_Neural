namespace Swimmer_Performance_Predictor
{
    using System;
    using Helpers;

    class Heartbeat
    {
        static void Main(string[] args)
        {
            ConsoleController consoleController = new ConsoleController();
            try
            {
                string DIRECTORY = Properties.Settings.Default.FolderPath;
                System.IO.Directory.CreateDirectory(DIRECTORY);
                consoleController.ChangeColor(ConsoleColor.Green);
                Console.WriteLine("Save Directory Initialized !");
            }
            catch (Exception ex)
            {
                consoleController.ChangeColor(ConsoleColor.Red);
                Console.WriteLine("Directory could not be created. \n\n Details: ", ex.Message);
                new ConsoleController().FreezeConsole();
            }

            consoleController.ChangeColor(ConsoleColor.White);

            Console_Helper consoleHelper = new Console_Helper();
            consoleHelper.PrintUserInstructons();

            Console.WriteLine("Select one of the above options: ");
            var userOption = Console.ReadLine();
            try
            {
                int selection = Convert.ToInt32(userOption);
                consoleHelper.NeuralOrFuzzy(selection);

            }
            catch (Exception ex)
            {
                new Helpers.ConsoleController().ChangeColor(ConsoleColor.Red);
                Console.WriteLine("The option you have selected is invalid \n\n Details: \n" + ex.Message);
            }
        }
    }
}
