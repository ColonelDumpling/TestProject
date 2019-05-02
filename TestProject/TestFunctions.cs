using System;
using System.IO;
using static TestProject.Utility;

namespace TestProject
{
    public class TestFunctions
    {
        public void TestFunction1()
        {
            // write the phrase "Hello World" to lvPath. (phrase is appended if lvPath already exists)
            var lvDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var lvPath = Path.Combine(lvDocuments, "outputTest.txt");
            using (var sr = new StreamWriter(lvPath, File.Exists(lvPath)))
            {
                sr.WriteLine("Hello World");
            }

            // count and output the number of lines in the file @ lvPath
            int lvLines = 0;
            using (var sr = new StreamReader(lvPath))
            {
                while (sr.Peek() != -1)
                {
                    sr.ReadLine();
                    lvLines++;
                }
            }
            Console.WriteLine(String.Format("{0} contained {1} lines", lvPath, lvLines));
        }
    }
}
