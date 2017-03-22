using System;
using System.IO;

namespace Helpers
{
    public class WriteTextFile
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

        public void writeToFile(String path, double content, String comment)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(comment);
                file.WriteLine(content);
                file.WriteLine("\n");
            }
        }


        public void writeToFile(String path, string content, String comment)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(comment);
                file.WriteLine(content);
                file.WriteLine("\n");
            }
        }

        public void writeToFile(String path, int content, String comment)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(comment);
                file.WriteLine(content);
                file.WriteLine("\n");
            }
        }

        public void clearFile(String path)
        {
            File.WriteAllText(path, String.Empty);
        }

        public string tab()
        {
            return "\t";
        }

        public void TabOrNull(String path, bool withTab)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                if (withTab)
                {
                    file.Write("\t \t");
                }
            }
        }
    }
}

