//Composite pattern lets clients treat the individual objects in a uniform manner. 
//Composite pattern is a partitioning design pattern that lets treat group of objects as a single type of object.The intent of a composite 
//pattern is to compose objects into tree structures to represent part-whole hierarchies. 

void Main()
{
	var dev = new Developer("elif",122222);
	var des = new Designer("esra",12343432);
	var org = new Organization();
	org.AddEmployee(dev);
	org.AddEmployee(des);
}

public abstract class Employee
{
	#region Properties
	
	protected float Salary {get ; set;}
	protected string Name {get; set;}
	protected string [] Roles {get; set; }
	
	#endregion
	
	#region Methods
	
	public Employee(string name, float salary)
	{
		Name = name;
		Salary = salary;
	}
	public string GetName()
	{
		return Name;
	}
	public void SetSalary(float salary)
	{
		Salary = salary; 
	}
    public float getSalary()
	{
		return Salary; 
	}
	
	#endregion
}

public class Developer : Employee 
{
	public Developer(string name,float salary):base(name,salary)
	{}
}

public class Designer : Employee
{
	public Designer(string name,float salary):base(name,salary)
	{}
}

public class Organization
{
	public List<Employee> Employees {get; set;}
	public Organization() {
		Employees = new List<Employee>();
	}
	public void AddEmployee(Employee employee)
	{
		Employees.Add(employee);
	}

}
