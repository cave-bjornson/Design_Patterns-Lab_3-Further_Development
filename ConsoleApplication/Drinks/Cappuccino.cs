namespace ConsoleApplication.Drinks;

public class Cappuccino : IWarmDrink
{
    public string DisplayName => "Cappuccino";

    public void Consume()
    {
        Console.WriteLine("Cappuccino is served.");
    }
}