using ConsoleApplication.Drinks;

namespace ConsoleApplication.Factories;

public interface IWarmDrinkFactory
{
    string ProductName { get; }
    
    IWarmDrink Prepare(int total);
}