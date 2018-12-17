void Main()
{
	var var1 = DoorFactory.makeDoors(20,30,DoorType.IronDoor);
	var var2 = DoorFactory.makeDoors(20,30,DoorType.WoodenDoor);
	Console.WriteLine(var1);
	Console.WriteLine(var2);
}

public enum DoorType 
{
	IronDoor = 1,
	WoodenDoor = 2
}

//simple factory 

public class IronDoor : Door 
{
	public IronDoor(int width, int height)
	{
		Width = width; 
		Height = height;
	}
	
	public int Width {get; set;}
	 
	public int Height {get; set;}

	public int getWidth ()
	{
		return Height;
	}
	
	public int getHeight ()
	{
		return Height;
	}
	

}

public class WoodenDoor : Door
{
	public WoodenDoor(int width, int height)
	{
		Width = width;	
		Height = height; 
	}
	
	public int Width {get; set;}
	    
	public int Height {get; set;}

	public int getWidth ()
	{
		return Height;
	}
	
	public int getHeight ()
	{
		return Height;
	}
}

public interface Door 
{
	int getWidth();
	
	int getHeight();
}

public class DoorFactory
{
	public static Door makeDoors (int width,int height,DoorType type)
	{
		switch(type)
		{
			case DoorType.WoodenDoor:
				return new WoodenDoor(width,height);
			case DoorType.IronDoor:
				return new IronDoor(width,height);
			default:
				return null; 
		}
	}
}
