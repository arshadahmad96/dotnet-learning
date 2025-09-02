namespace Catalog
{
    public class Product
    {
        // public int Id { get; set; }
        // public string Name { get; set; }
        // public decimal Price { get; set; }

        private string name;
        private decimal price;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public Product(string name, decimal price)
        {
            this.SetName(name);
            this.SetPrice(price);
        }
    }
}