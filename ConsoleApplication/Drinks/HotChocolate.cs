namespace ConsoleApplication.Drinks;

public class HotChocolate : IWarmDrink
{
    public string DisplayName => "Cappuccino";

    public void Consume()
    {
        Console.WriteLine("Hot chocolate is served.");
    }
}