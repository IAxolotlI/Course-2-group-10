using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            public string Name;
            public int Age;
            public void Introduce()
            {
                Console.WriteLine($"Привет, мое имя {Name}");
            }
            public Person()//конструктор
            {
                Age = 30;
                Name = "name";
            }
            public void SetAge(int x)
            {
                if (x >= 0) Age = x;
                else Console.WriteLine("Age cannot be negative");
            }
            public void SetName(string a)//так чисто вместе с возрастом написал
            {
                Name = a;
            }
        }
        class Employee : Person
        {
            public string position;
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 22;
            p.Name = "Egor Grigorenko";
            Person c = new Person();
            c.Age = 27;
            c.Name = "Alexandr Nix";
            Person[] b = {p, c};
            for ( int i = 0; i < b.Length; i++ )
            {
                b[i].Introduce();
            }

            Employee employee = new Employee();
            employee.SetName("rab");
            employee.SetAge(156);
            employee.position = "Trudyaga";
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.position);
        }
    }
}
