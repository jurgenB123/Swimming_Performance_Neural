using System;

namespace Neural_Network
{
    class ConsoleController
    {
        public void FreezeConsole()
        {
            Console.ReadLine();
        }

        public void WriteToConsole(String content)
        {
            Console.WriteLine(content);
        }
    }
}
