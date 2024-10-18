using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f(int x)
            {
                if (x == 1) return 1;
                else return f(x - 1) * x;
            }
            Console.WriteLine(f(5));
        }
    }
}
