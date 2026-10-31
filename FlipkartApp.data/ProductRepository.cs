using System.Collections.Generic;
using System.Linq;

namespace FlipkartApp.Data
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone", Price = 70000, Description = "Apple smartphone" },
            new Product { Id = 2, Name = "Samsung TV", Price = 45000, Description = "Smart LED TV" }
        };

        public List<Product> GetProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Max(x => x.Id) + 1;
            _products.Add(product);
        }
    }
}
