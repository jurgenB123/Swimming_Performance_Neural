using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
