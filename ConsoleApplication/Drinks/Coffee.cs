namespace ConsoleApplication.Drinks;

public class Coffee : IWarmDrink
{
    public string DisplayName => "Coffee";

    public void Consume()
    {
        Console.WriteLine("Coffee is served.");
    }
}