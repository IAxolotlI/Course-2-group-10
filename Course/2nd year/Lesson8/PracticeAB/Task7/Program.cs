using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static int vow(string s)
        {
            int k = 0;
            string vowels = "аиоуеэАИОУЕЭ";
            foreach (char c in s)
            {
                if (vowels.Contains(c)) { 
                    k++; 
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            string s = "ааабббффоЭУ";
            Console.WriteLine(vow(s));
        }
    }
}
