using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f(int x){
                return x % 2 == 0;
            }
            Console.WriteLine(f(45));
        }
    }
}
