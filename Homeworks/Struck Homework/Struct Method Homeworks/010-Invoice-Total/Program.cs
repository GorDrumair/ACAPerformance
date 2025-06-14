using System;

namespace InvoiceTotal;

class Program
{
    static void Main(string[] args)
    {
        InvoiceTotal invoice = new InvoiceTotal(19.99m, 3);
        Console.WriteLine($"Unit Price: {invoice.UnitPrice}");
        Console.WriteLine($"Quantity: {invoice.Quantity}");
        Console.WriteLine($"Total: {invoice.GetTotal()}");
    }
}

struct InvoiceTotal
{
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }

    public InvoiceTotal(decimal unitPrice, int quantity)
    {
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public decimal GetTotal()
    {
        return UnitPrice * Quantity;
    }
}