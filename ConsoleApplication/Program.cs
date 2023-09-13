using ConsoleApplication;
using ConsoleApplication.Drinks;

var machine = new WarmDrinkMachine();
IWarmDrink drink = machine.MakeDrink();
drink.Consume();