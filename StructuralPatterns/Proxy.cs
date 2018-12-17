void Main()
{
	var door = new LabDoor();
	var secureDoor = new SecuredDoor(door);
	secureDoor.Open("password");
	secureDoor.Open("wrongpassword");
}

//Proxy pattern: 

//Real world example
//
//Have you ever used an access card to go through a door? There are multiple options to open that door i.e. 
//it can be opened either using access card or by pressing a button that bypasses the security. 
//The door's main functionality is to open but there is a proxy added on top of it to add some functionality.

//In plain words : 
//
//Using proxy pattern, a class represents the functionality of another class. 
//
//Wiki says: 
//A proxy, in its most general form, is a class functioning as an interface to something else. 
//A proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes. 
//Use of the proxy can simply be forwarding to the real object, or can provide additional logic. 
//In the proxy extra functionality can be provided, for example caching when operations on the real object are resource intensive, 
//or checking preconditions before operations on the real object are invoked.


public interface Door
{
	void Open();
	
	void Close();
	
}

public class LabDoor : Door 
{
	public void Open()
	{
		Console.WriteLine("open the door");
	}
	
	public void Close()
	{
		Console.WriteLine("close the door");
	}

}

public class SecuredDoor 
{
	protected Door Door {get; set; }
	
	public SecuredDoor(Door door)
	{
		Door = door; 
	}
	
	public void Open(string password)
	{
		if (Authenticate(password))
		{
			Door.Open();
		}
		else
		{
			Console.WriteLine("Password is not correct.");
		}
	}
	
	public bool Authenticate(string password)
	{
		return password == "password";
	}

}
