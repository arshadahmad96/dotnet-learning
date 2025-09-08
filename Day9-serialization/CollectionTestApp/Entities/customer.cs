namespace CRM;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public Customer(int id, string name, int v)
    {
        this.Id = id;
        this.Name = name;
        this.Age = v;
    }
}