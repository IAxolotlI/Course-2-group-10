using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ctof(double x)
            {
                return x * 9 / 5 + 32;
            }
            Console.WriteLine(ctof(36.6));
        }
    }
}
