using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static int salary(int x)
        {
            return x * 12;
        }
        static void Main(string[] args)
        {
            int x = 50000;
            Console.WriteLine(salary(x));
        }
    }
}
