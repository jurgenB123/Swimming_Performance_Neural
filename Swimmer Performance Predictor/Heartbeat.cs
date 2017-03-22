using Helpers;
namespace Swimmer_Performance_Predictor
{
    using Neural_Network;
    using Fuzzy_Logic;
    using System;

    class Heartbeat
    {
        static void Main(string[] args)
        {
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
