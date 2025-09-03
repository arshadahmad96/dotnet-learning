namespace Catalog;

    public interface IProductService
    {
        void AddProduct(string name, decimal price);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(int id, string name, decimal price);
        void DeleteProduct(int id);
    }

