namespace ConsoleApplication.Drinks;

public class Coffee : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Coffee is served.");
    }
}