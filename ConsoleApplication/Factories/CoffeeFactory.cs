using ConsoleApplication.Drinks;

namespace ConsoleApplication.Factories;

public class CoffeeFactory : IWarmDrinkFactory
{
    public string ProductName => "Coffee";
    
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml coffee in your cup");
        return new Water();
    }
}