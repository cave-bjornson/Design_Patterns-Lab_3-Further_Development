using ConsoleApplication.Drinks;

namespace ConsoleApplication.Factories;

public class HotWaterFactory : IWarmDrinkFactory
{
    public string ProductName => "Hot Water";
    
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot water in your cup");
        return new Water();
    }
}