using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static int generate_password(string s)
        {
            int count = 0;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            count++;
                            string gpass = a.ToString()+ b.ToString()+ c.ToString()+ d.ToString();
                            if (gpass == s)
                            {
                                Console.WriteLine("Ура! Вы взломали пароль!");
                                return count;
                            }
                        }
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            string s = "3111";
            Console.WriteLine(generate_password(s));
        }
    }
}
