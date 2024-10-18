using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f(string s)
            {
                return "Привет, " + s;
            }
            Console.WriteLine(f("Матвей"));
        }
    }
}
