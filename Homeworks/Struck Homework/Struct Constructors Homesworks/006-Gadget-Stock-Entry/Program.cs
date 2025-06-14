using System;

namespace GadgetStockEntry;

class Program
{
    static void Main(string[] args)
    {
        Gadget gadget = new Gadget("Smartphone", "TechBrand", 699.99m, 50);
        Gadget gadget2 = new Gadget("Laptop", "CompTech", 1299.99m, 30);
    }
}

struct Gadget
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Gadget(string name, string brand, decimal price, int quantity)
    {
        Name = name;
        Brand = brand;
        Price = price;
        Quantity = quantity;
    }
}