
using Catalog;
using HR;
int count = 45;
count++;
if (count > 50)
{
    Console.WriteLine("Count exceeded 50");
}
else
{
    Console.WriteLine("Count is within the limit");
}
Console.WriteLine(count);

Product product = new Product("Laptop", 1500.00m);
Console.WriteLine($"Product Name: {product.GetName()}, Price: {product.GetPrice()}");


SalesEmployee se = new SalesEmployee("John Doe", 12345, 50000);
Console.WriteLine($"Sales Employee Name: {se.GetName()}, ID: {se.GetId()}, Salary: {se.GetSalary()}");


IProductRepository productRepository = new ProductRepository();
IProductService productService = new ProductService(productRepository);

List<Product> products = new List<Product>
{
    new Product("Laptop", 1500.00m),
    new Product("Smartphone", 800.00m),
    new Product("Tablet", 400.00m)
};

foreach (var item in products)
{
    productService.AddProduct(item);
}