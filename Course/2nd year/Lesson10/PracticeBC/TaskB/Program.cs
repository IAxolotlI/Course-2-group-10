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

        class Person
        {
            public string Name;
            public int Age;
            public void SetAge(int x)
            {
                if (x >= 0) Age = x;
                else Console.WriteLine("Age cannot be negative");
            }
            public void SetName(string a)
            {
                if (Name != null) Name = a;
                else Console.WriteLine("Where is string?");
            }
        }

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
                    return reader.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string path = "test1.txt";
            FileHandler fileHandler = new FileHandler(path);
            Console.WriteLine("Введите количество людей:");
            int n = Console.Read();
            for (int i = 0; i < n; i++)// по моей идее этот цикл вводит в файл n строк вида "Имя Возраст"
            {
                //Console.WriteLine("Введите имя и возраст через пробел:");
                string content = Console.ReadLine();
                fileHandler.WriteToFile(content);
            }
            for (int i = 0; i < n; i++)// из этого файла получаем имя и возраст, даем это на корм объекту класса персон и толкаем его в лист
            {
                string fileContent = fileHandler.ReadFromFile();
                string Name = fileContent.Substring(0, fileContent.IndexOf(' '));
                int Age = Convert.ToInt32(fileContent.Substring(fileContent.IndexOf(' ') + 1));
                Person person = new Person();
                person.SetName(Name);
                person.SetAge(Age);
                list.Add(person);
                Console.WriteLine(Name, ' ', Age);
            }
        }
    }
}
