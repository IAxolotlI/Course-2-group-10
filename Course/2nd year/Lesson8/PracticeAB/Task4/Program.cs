using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static int maxArr(int[] a)
        {
            return a.Max(); 
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 7 };
            Console.WriteLine(maxArr(a));
        }
    }
}
