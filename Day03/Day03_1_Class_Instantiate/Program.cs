/*
	Class Instantiate
*/
public class Program
{
	public static void Main()
	{
		Cat cat0 = new Cat();
		Cat cat1 = new();
		var cat2 = new Cat();
		//var cat3 = new(); <- Error
	}
	
}

public class Cat {
	public string name = "";
	private int age;
	
	public void Jump() {
		Console.WriteLine("Jump");
	}
	protected void Eat() {
		Console.WriteLine("Eat");
	}
}
