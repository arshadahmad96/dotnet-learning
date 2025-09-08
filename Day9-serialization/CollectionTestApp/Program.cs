using System.Text.Json;
using CRM;
using System.IO;

Customer cust = new Customer(1, "Alic", 56);
string JsonString = JsonSerializer.Serialize(cust);
Console.WriteLine($"{JsonString}");
//
File.WriteAllText("customer.json", JsonString);