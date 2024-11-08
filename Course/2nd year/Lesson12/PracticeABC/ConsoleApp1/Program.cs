using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Product//1
        {
            public string name;
            public int price;
            public string description;
        }
        public class Shop//2
        {
            public string category;
            public List<string> products;
        }
        public class Order//3
        {
            public int id;
            public List<string> items;
            public int total;
        }
        public class User//4
        {
            public string name;
            public string email;
            public int purchases;
        }
        public class Cart//5
        {
            public List<string> products;
        }
        public class Shipping//6
        {
            public string method;
            public int price;
            public int estimated_days;
        }
        public class Payment//7
        {
            public string method;
            public string status;
        }

        public class Review//8
        {
            public string product;
            public int rating;
            public string comment;
        }
        public class Otz
        {
            public List<Review> reviews;
        }

        public class Discount//9
        {
            public string product;
            public string discount;
        }
        public class Shop1
        {
            public List<Discount> discounts;
        }

        public class Address//10
        {
            public string type;
            public string address;
        }
        public class Town
        {
            public List<Address> addresses;
        }

        static void Main(string[] args)
        {
        }
    }
}
