using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class FileHandler
        {
            private string filePath;
            public FileHandler(string path)
            {
                filePath = path;
            }
            public void WriteToFile(string content)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(content);
                }
            }
            public string ReadFromFile()
            {
                using (StreamReader reader = new StreamReader(filePath, true))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        static void Main(string[] args)
        {
            string path = "test.txt";
            FileHandler fileHandler = new FileHandler(path);
            string content = Console.ReadLine();
            fileHandler.WriteToFile(content);

            string fileContent = fileHandler.ReadFromFile();
            Console.WriteLine(fileContent);
        }
    }
}
