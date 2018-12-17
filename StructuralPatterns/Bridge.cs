void Main()
{
	var darkTheme = new DarkTheme();
	var about = new About();
	about.DetemineThemeColor(darkTheme);
	
}

//Bridge pattern 
//Bridge pattern is a design pattern used in software engineering that is meant to "decouple an abstraction from its implementation so that the two can vary independently"
//It is about preferring composition over inheritance. 
//Implemantation details are pushed from a hierarchy to another object with a seperate hiearachy.

public interface WebPage
{
	 void CreatePageContent();
}

public interface Theme
{
	string ThemeColor {get; set;}
}

public class DarkTheme: Theme
{
	public string ThemeColor {get; set;}

	public DarkTheme()
	{
		ThemeColor = "Dark";
	}
}


public class LightTheme: Theme
{
	public string ThemeColor {get; set;}

	public LightTheme()
	{
		ThemeColor = "Light";
	}
}

public class AquaTheme: Theme
{
	public string ThemeColor {get; set;}
	
	public AquaTheme()
	{
		ThemeColor = "Aqua";
	}
	
}

public class About : WebPage
{
	public void CreatePageContent() {}
	
	public Theme Theme {get; set;}
	
	public void DetemineThemeColor(Theme theme) 
	{
		Theme = theme;
		Console.WriteLine(theme.ThemeColor);
	}
}

public class Projects : WebPage
{
	public void CreatePageContent() {}
	public void DetemineThemeColor(string color) 
	{
		
	}
}

public class Careers: WebPage
{
	public void CreatePageContent() {}
	public void DetemineThemeColor(Theme theme) 
	{
		
	}
}
