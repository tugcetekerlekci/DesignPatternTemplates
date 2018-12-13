//Factory Method

void Main()
{
	var devManager = new DevelopmentManager();
	devManager.MakeInterviewer();
	devManager.TakeInterviews();
	
	var comManager = new CommunityManager();
	comManager.MakeInterviewer();
	comManager.TakeInterviews();
	
}

public interface Interviewer 
{
	 void AskQuestions();
}

public class Developer : Interviewer
{
	public void AskQuestions()
	{
		Console.WriteLine("What is programming? ");
	}
}


public class CommunityExecutive : Interviewer
{
	public void AskQuestions()
	{
		Console.WriteLine("What is community executive? ");
	}
}

protected abstract class HiringManager
{
	protected Interviewer Interviewer {get; set;}
	
	public abstract Interviewer MakeInterviewer();
	
	public void TakeInterviews()
	{
		Interviewer = MakeInterviewer();
		
		Interviewer.AskQuestions();
	}

}

protected class DevelopmentManager : HiringManager
{
	public override Interviewer MakeInterviewer()
	{
		return new Developer();
	}
}

protected class CommunityManager : HiringManager
{
	public override Interviewer MakeInterviewer()
	{
		return new CommunityExecutive();
	}

}
