namespace ConsoleApplication.Drinks;

public class HotChocolate : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Hot chocolate is served.");
    }
}