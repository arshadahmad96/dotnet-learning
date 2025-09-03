using System.Collections.Generic;
using System.Linq;

namespace Catalog
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>();
        private int nextId = 1;

        public void AddProduct(Product product)
        {
            product.SetId(nextId++);
            products.Add(product);
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.GetId() == id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
        }

        public void DeleteProduct(int id)
        {
        }
    }
}
