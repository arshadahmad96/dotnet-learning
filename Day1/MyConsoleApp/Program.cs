using Catalog;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Laptop", 999.99m);
        Console.WriteLine($"Product Name: {product.GetName()}");
        Console.WriteLine($"Product Price: {product.GetPrice()}");
    }
}
