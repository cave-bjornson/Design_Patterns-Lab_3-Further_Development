namespace ConsoleApplication.Drinks;

public class Cappuccino : IWarmDrink
{ 
    public void Consume()
    {
        Console.WriteLine("Cappuccino is served.");
    }
}