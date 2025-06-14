using System;

namespace BankTransactions;

class Program
{
    static void Main(string[] args)
    {
        Transaction transaction = new Transaction(1, 100.50m);
        Transaction transaction2 = new Transaction(2, 200.75m);
    }
}

struct Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Datestamp { get; set; }

    public Transaction(int id, decimal amount)
    {
        Id = id;
        Amount = amount;
        Datestamp = DateTime.Now;
    }
}