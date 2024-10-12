using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static string reverse_string(string s)
        {
            string reversed="";
            for (int i = s.Length - 1; i >= 0; --i)
            {
                reversed += s[i];
            }
            return reversed;
        }
  
        static void Main(string[] args)
        {
            string a = "123456";
            Console.WriteLine(reverse_string(a));
        }
    }
}
