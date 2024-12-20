using PracticeA.Classes;

namespace PracticeA.Repositories
{
    public interface IProductRepository
    {
        public void Update_Price(string name, double newPrice);
        public void Update_Name(string name, string newName);
        public List<Product>? OutOfStock();
        public void AddProduct(Product product);
        public void DeleteProduct(string name);
        public List<Product> GetAllProducts();
    }
}
