using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f(string x)
            {
                string s = "";
                for (int i = x.Length-1; i >= 0; i--)
                {
                    s += x[i];
                }
                return s;
            }
            Console.WriteLine(f("Цивилизация"));
        }
    }
}
