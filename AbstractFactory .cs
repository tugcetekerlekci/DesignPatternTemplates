//Abstract Factory 
void Main()
{
	var ironDoorFactory = new IronDoorFactory();
	ironDoorFactory.MakeDoor().getDescription();
	ironDoorFactory.MakeDoorFittingExpert().getDescription();
	Console.WriteLine("-------------------------");
	var woodenDoorFactory = new WoodenDoorFactory();
	woodenDoorFactory.MakeDoor().getDescription();
	woodenDoorFactory.MakeDoorFittingExpert().getDescription();
	
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
		Console.WriteLine("this is carpenter");
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



