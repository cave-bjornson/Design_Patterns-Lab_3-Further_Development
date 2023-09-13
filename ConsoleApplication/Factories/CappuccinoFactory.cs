using ConsoleApplication.Drinks;

namespace ConsoleApplication.Factories;

public class CappuccinoFactory : IWarmDrinkFactory
{
    public string ProductName => "Cappuccino";
    
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml cappuccino in your cup");
        return new Water();
    }
}