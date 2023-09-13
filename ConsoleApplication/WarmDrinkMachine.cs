using ConsoleApplication.Drinks;
using ConsoleApplication.Factories;

namespace ConsoleApplication;

public class WarmDrinkMachine
{
    private List<Tuple<string, IWarmDrinkFactory>> namedFactories = new();

    public WarmDrinkMachine()
    {
        foreach (var t in typeof(WarmDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IWarmDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                namedFactories.Add(Tuple.Create(
                    t.Name.Replace("Factory", string.Empty), (IWarmDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }
    
    public IWarmDrink MakeDrink()
    {
        Console.WriteLine("This is what we serve today:");
        for (var index = 0; index < namedFactories.Count; index++)
        {
            var tuple = namedFactories[index];
            Console.WriteLine($"{index + 1}: {tuple.Item2.ProductName}");
        }
        Console.WriteLine("Select a number to continue:");
        while (true)
        {
            string s;
            if ((s = Console.ReadLine()) != null
                && int.TryParse(s, out int i) // c# 7
                && i >= 1
                && i <= namedFactories.Count)
            {
                Console.Write("How much: ");
                s = Console.ReadLine();
                if (s != null
                    && int.TryParse(s, out int total)
                    && total > 0)
                {
                    return namedFactories[i - 1].Item2.Prepare(total);
                }
            }
            Console.WriteLine("Something went wrong with your input, try again.");
        }
    }
}