
//Real world example
//
//Imagine you run a car service shop offering multiple services. Now how do you calculate the bill to be charged? 
//You pick one service and dynamically keep adding to it the prices for the provided services till you get the final cost. 
//Here each type of service is a decorator.
//
//In plain words
//
//Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class.
//
//Wikipedia says
//
//In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to an individual object, 
//either statically or dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often 
//useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas 
//of concern.



void Main()
{
	var coffee = new SimpleCoffee();
	var latte = new Latte(coffee);
	Console.WriteLine(latte.GetCost());
}

public interface Coffee 
{
	int GetCost();
	
	string GetDescription();
}

public class SimpleCoffee : Coffee
{
	public int GetCost()
	{
		return 10; 
	}
	
	public string GetDescription()
	{
		return "Simple Coffee";
	}
}

public class MilkCoffee : Coffee
{
	public Coffee Coffee {get; set;}
	MilkCoffee(Coffee coffee)
	{
		Coffee = coffee;
	}
	public int GetCost()
	{
		return Coffee.GetCost()+2; 
	}
	
	public string GetDescription()
	{
		return "Milk Coffee";
	}
}

public class Latte : Coffee
{
	
	public Coffee Coffee {get; set;}
	
	public Latte(Coffee coffee)
	{
		Coffee = coffee;
	}
	public int GetCost()
	{
		return Coffee.GetCost()+3; 
	}
	
	public string GetDescription()
	{
		return "Latte";
	}
}
