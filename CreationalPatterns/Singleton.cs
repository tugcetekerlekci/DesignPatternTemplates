//--------------------------------------------------------------------------------------------------------------------------------------//

//Singleton implementation 
// read this link : http://csharpindepth.com/articles/general/singleton.aspx#lock

//1- classic nonthread safe implementation

class Singleton1 
{
	private static Singleton1 obj ; 
	private Singleton() {}
	public static Singleton GetInstance()
	{
		if (obj ==null)
		{
			return new Singleton1();
		}
		return obj; 
	}
}

//Drawbacks- comments 
//Here we have declared getInstance() static so that we can call it without instantiating the class. 
//The first time getInstance() is called it creates a new singleton object and after that it just returns the same object. 
//Note that Singleton obj is not created until we need it and call getInstance() method. This is called lazy instantiation.
//The main problem with above method is that it is not thread safe. Consider the following execution sequence.
 
//--------------------------------------------------------------------------------------------------------------------------------------//
//Syncronized thread safe version
class Singleton2
{
	private static Singleton2 obj ; 
	private Singleton2(){}
	public static synchronized GetInstance()
	{
		if (obj == null)
		{
			return new Singleton2();
		}
		return obj; 
	}
}
//Drawbacks - comments 
//The main disadvantage of this is method is that using synchronized every time while creating the singleton object is expensive and 
//may decrease the performance of your program. However if performance of getInstance() is not critical for your application this method 
//provides a clean and simple solution.
//--------------------------------------------------------------------------------------------------------------------------------------//

//Eager Instantiation
class Singleton3
{
	private static Singleton3 obj = new Singleton3();
	private Singleton3() {}
	private static Singleton3 getInstance()
	{
		return obj;
	}

}

//Drawbacks - comments 
//Here we have created instance of singleton in static initializer. JVM executes static initializer when the class is loaded and 
//hence this is guaranteed to be thread safe. Use this method only when your singleton class is light and is used throughout the execution of your program.

//--------------------------------------------------------------------------------------------------------------------------------------//
//Double checked logging 
class Singleton4()
{
	private volatile static Singleton4 obj;
	private Singleton4(){}
	public static GetInstance()
	{
		if (obj == null)
		{
			synchronized(Singleton4.class)
			{
				if (obj == null)
				{
					return new Singleton3();
				}
			}
		}
		
		return obj; 
	}
}

//We have declared the obj volatile which ensures that multiple threads offer the obj variable correctly when it is being initialized to Singleton instance. 
//This method drastically reduces the overhead of calling the synchronized method every time.
