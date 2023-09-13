namespace ConsoleApplication.Drinks;

public class Water : IWarmDrink
{ 
    public void Consume()
    {
        Console.WriteLine("Warm water is served.");
    }
}