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
