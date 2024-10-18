using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f(int x)
            {
                if (x % 2 == 0) return "Sotasvnoe";
                else {
                    for (int i = 3; i < x / 2 + 1; i += 2)
                    { //вообще до sqrt(x) надо идти, но я не знаю, как подключить библоиотеку math
                        if (x % i == 0) return "Sotasvnoe";
                    }
                }
                return "Prostoe";
            }
            Console.WriteLine(f(13));
        }
    }
}
