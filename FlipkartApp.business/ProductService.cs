using FlipkartApp.Data;
using System.Collections.Generic;

namespace FlipkartApp.Business
{
    public class ProductService
    {
        private readonly ProductRepository _repo = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return _repo.GetProducts();
        }

        public void AddProduct(Product product)
        {
            _repo.AddProduct(product);
        }
    }
}
