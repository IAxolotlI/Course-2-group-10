using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f(string s)
            {
                int c = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i]=='k')c++;
                }
                return c;
            }
            Console.WriteLine(f("aasdkkksssewrk"));
        }
    }
}
