using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f(int a, int b)
            {
                if (a >= b) return a;
                else return b;
            }
            Console.WriteLine(f(7,3));
        }
    }
}
