using System;

namespace CurrencyConverter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Currency Converter!");

        Currency usd = new Currency(100, 1.0);
        Currency eur = new Currency(85, 0.85);

        decimal convertedAmount = usd.ConvertTo((decimal)eur.CurrencyRate);
        Console.WriteLine($"Converted Amount: {convertedAmount} EUR");

        convertedAmount = eur.ConvertTo((decimal)usd.CurrencyRate);
        Console.WriteLine($"Converted Amount: {convertedAmount} USD");
    }
}

struct Currency
{
    public decimal Amount { get; set; }
    public double CurrencyRate { get; set; }

    public Currency(decimal amount, double currencyRate)
    {
        Amount = amount;
        CurrencyRate = currencyRate;
    }

    public decimal ConvertTo(decimal targetRate)
    {
        return Math.Round(Amount * (targetRate / (decimal)CurrencyRate), 2);
    }
}