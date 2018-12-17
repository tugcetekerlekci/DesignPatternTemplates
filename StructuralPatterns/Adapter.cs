//Adapter pattern lets you wrap an incompatible object in an adapter to make it compatible with another class. 
//Adapter pattern is a design pattern that allows you to an interface of an existing class to be used as another interface. It is often 
//used to make existing classes work with other classes without modifyting their source code. 

void Main()
{
	var dog = new WildDog();
	var wildDogAdapter = new WildDogAdapter(dog);
	var hunter = new Hunter();
	hunter.Hunt(wildDogAdapter)
}

public interface Lion
{
	void Roar();
}

public class AfricanLion : Lion 
{
	public void Roar()
	{
		
	}
}


public class AsianLion : Lion 
{
	public void Roar()
	{
		
	}
}

public class Hunter 
{
	public void Hunt(Lion lion)
	{
		lion.Roar();
	}
}

public class WildDog
{
	public void Bark()
	{
	}
}

public class WildDogAdapter : Lion
{
	public WildDogAdapter(WildDog dog)
	{
		Dog = dog;
	}
	protected WildDog Dog {get; set;}
	public void Roar()
	{
		Dog.Bark();
	}

}
