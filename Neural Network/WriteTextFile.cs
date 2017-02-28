using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class WriteTextFile
    {
        public void writeToFile(String path, double[] content, String comment)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(comment);

                for (int i = 0; i < content.Length; i++)
                {
                    file.Write(content[i] + "\t");
                }
                file.WriteLine("\n");
            }
        }
    }
}
