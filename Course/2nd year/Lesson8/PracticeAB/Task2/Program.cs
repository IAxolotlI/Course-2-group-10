using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static bool is_even(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(is_even(a));
        }
    }
}
