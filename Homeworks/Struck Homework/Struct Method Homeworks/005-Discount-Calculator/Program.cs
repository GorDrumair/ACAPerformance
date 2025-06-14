using System;

namespace DiscountCalculator;

class Program
{
    static void Main(string[] args)
    {
        DiscountCalculator calculator = new DiscountCalculator();
        calculator.price = 100.0;
        calculator.discountPercentage = 20.0;

        double finalPrice = calculator.GetFinalPrice();
        Console.WriteLine($"The final price after discount is: {finalPrice}");
    }
}

struct DiscountCalculator
{
    public double price;
    public double discountPercentage;

    public double GetFinalPrice()
    {
        return price - (price * discountPercentage / 100);
    }
}