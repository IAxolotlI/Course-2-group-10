﻿using System.ComponentModel.DataAnnotations;

namespace PracticeA.Classes
{
    public class Product
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Range(0.01, 10000)]
        public double Price { get; set; }

        [Range(0, 10000)]
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
