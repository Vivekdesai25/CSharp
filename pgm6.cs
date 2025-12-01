using System;
using System.Collections.Generic;

class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ProductID=1, Name="Laptop", Price=50000},
            new Product(){ProductID=2, Name="Mouse", Price=500}
        };

        foreach (var p in products)
        {
            Console.WriteLine($"{p.ProductID} - {p.Name} - {p.Price}");
        }
    }
}
