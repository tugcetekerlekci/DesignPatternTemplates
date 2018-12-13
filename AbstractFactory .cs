//Abstract Factory 
void Main()
{
	var ironDoorFactory = new IronDoorFactory();
	Console.WriteLine(ironDoorFactory.MakeDoor());
	Console.WriteLine(ironDoorFactory.MakeDoorFittingExpert());
	
	var woodenDoorFactory = new WoodenDoorFactory();
	Console.WriteLine(woodenDoorFactory.MakeDoor());
	Console.WriteLine(woodenDoorFactory.MakeDoorFittingExpert());
	
}

public interface Door 
{
	 void getDescription();
}

public class WoodenDoor : Door 
{
	public void getDescription()
	{
		Console.WriteLine("this is a wooden door");
	}
}

public class IronDoor : Door 
{
	public void getDescription()
	{
		Console.WriteLine("this is a iron door");
	}
}

public interface DoorFittingExpert
{
	void getDescription();
}

public class Welder : DoorFittingExpert
{
	public void getDescription()
	{
		Console.WriteLine("this is welder");
	}
}

public class Carpenter : DoorFittingExpert
{
	public void getDescription()
	{
		Console.WriteLine("this is welder");
	}
}
 public abstract class DoorFactory<TDoorType,TDoorFittingExpert>
 where TDoorType: Door, new()
 where TDoorFittingExpert: DoorFittingExpert, new()
 {
 	public TDoorType MakeDoor()
	{
		return new TDoorType();
	}
	
	public TDoorFittingExpert MakeDoorFittingExpert()
	{
		return new TDoorFittingExpert();
	}
	
 }

public class IronDoorFactory: DoorFactory<IronDoor,Welder>
{
	
}

public class WoodenDoorFactory: DoorFactory<WoodenDoor,Carpenter>
{
	
}



