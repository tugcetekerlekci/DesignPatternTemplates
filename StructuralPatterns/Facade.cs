//Facade Pattern : simple interface to a complex system. 

//Real word Example: 
//How do you turn on the computer? "Hit the power button" you say! That is what you believe because you are using a simple interface 
//that computer provides on the outside, internally it has to do a lot of stuff to make it happen. 
//This simple interface to the complex subsystem is a facade.

//In plain words
//
//Facade pattern provides a simplified interface to a complex subsystem.



//Wikipedia says
//
//A facade is an object that provides a simplified interface to a larger body of code, such as a class library.

void Main()
{
	var computer = new Computer();
	var computerFacade = new ComputerFacade(computer);
	computerFacade.TurnOn();
	computerFacade.TurnOff();
}


public class Computer
{
    public void getElectricShock()
    {
        Console.WriteLine( "Ouch!");
    }

    public void makeSound()
    {
        Console.WriteLine( "Beep beep!");
    }

    public void showLoadingScreen()
    {
        Console.WriteLine( "Loading..");
    }

    public void bam()
    {
        Console.WriteLine( "Ready to be used!");
    }

    public void closeEverything()
    {
        Console.WriteLine( "Bup bup bup buzzzz!");
    }

    public void sooth()
    {
        Console.WriteLine( "Zzzzz");
    }

    public void pullCurrent()
    {
        Console.WriteLine( "Haaah!");
    }
}

public class ComputerFacade
{
    protected Computer Computer {get; set; }

    public ComputerFacade(Computer computer)
    {
        Computer = computer;
    }

    public void TurnOn()
    {
        Computer.getElectricShock();
        Computer.makeSound();
        Computer.showLoadingScreen();
        Computer.bam();
    }

    public void TurnOff()
    {
        Computer.closeEverything();
        Computer.pullCurrent();
        Computer.sooth();
    }
}
