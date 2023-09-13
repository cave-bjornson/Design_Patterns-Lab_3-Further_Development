using ConsoleApplication.Drinks;

namespace ConsoleApplication.Factories;

public class HotChocolateFactory : IWarmDrinkFactory
{
    public string ProductName => "Hot Chocolate";
    
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot chocolate in your cup");
        return new Water();
    }
}