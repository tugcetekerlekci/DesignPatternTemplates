void Main()
{
	var burgerBuilder = new BurgerBuilder();
	burgerBuilder.addLettuce().addPickles().addTomatoes();
	burgerBuilder.printIngredients();
}


public class Burger
{

}

public class BurgerBuilder
{
	#region Properties
		
		public bool Lettuce { get; set;}
	
		public bool Pickles { get; set;}
	
		public bool Tomatoes { get; set;}
		
		public Dictionary<string,bool> Ingredients {get; set;}
	
	#endregion
	
	public BurgerBuilder()
	{
		MyBurger = new Burger();
		Ingredients = new Dictionary<string,bool>();
	}
	public Burger MyBurger {get; set; }
	
	public BurgerBuilder addLettuce()
	{
		Lettuce = true;
		Ingredients.Add("Lettuce",true);
		return this;
	}
	
	public BurgerBuilder addPickles()
	{
		Pickles = true;
		Ingredients.Add("Pickles",true);
		return this;
	}
	
	public BurgerBuilder addTomatoes()
	{
		Tomatoes = true;
		Ingredients.Add("Tomatoes",true);
		return this;
	}
	
	public void printIngredients()
	{
		var ings = "";
		foreach(KeyValuePair<string,bool> ingredient in Ingredients)
		{
			ings = ings + string.Format("{0} ",ingredient.Key);
		}
		Console.WriteLine(ings);
	}
}
