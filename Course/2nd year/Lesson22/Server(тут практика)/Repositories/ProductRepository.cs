using Microsoft.AspNetCore.Mvc;
using PracticeA.Classes;
using System.Xml.Linq;

namespace PracticeA.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product>? _products;
        private ClassDB _classDB;
        public ProductRepository()
        {
            _classDB.Read_Data_From_DB();
        }
        public void Update_Price(string name, double newPrice)
        {
            if (_products != null)
            {
                var product = _products.FirstOrDefault(p => p.Name == name);
                if (product != null)
                {
                    product.Price = newPrice;
                    SaveChanges();
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void Update_Name(string name, string newName)
        {
            if (_products != null)
            {
                var product = _products.FirstOrDefault(p => p.Name == name);
                if (product != null)
                {
                    product.Name = newName;
                    SaveChanges();
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public List<Product>? OutOfStock()
        {
            if (_products != null)
            {
                var outOfStockItems = _products.Where(p => p.Stock == 0).ToList();
                if (outOfStockItems.Any())
                {
                    return outOfStockItems;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            SaveChanges();
        }
        public void DeleteProduct(string name)
        {
            var product = _products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                _products.Remove(product);
                SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public List<Product> GetAllProducts()
        {
            if (_products != null)
            {
                return _products;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        private void SaveChanges()
        {
            _classDB.WriteDataToFile();
        }
    }
}
