using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static int conv_c_to_f(int x)
        {
            return x * 9 / 5 + 32;
        }
        static void Main(string[] args)
        {
            int x = 25;
            Console.WriteLine(conv_c_to_f(x));
        }
    }
}
