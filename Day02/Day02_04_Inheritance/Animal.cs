namespace LivingBeing;

public class Animal
{
	//variable
	public string name;
	public int age;
	
	//contructor
	public Animal(string name)
	{
		Console.WriteLine($"Animal instance created: {name}");
		this.name = name;
	}
	
	//method
	public void Eat()
	{
		Console.WriteLine("Eat");
	}
}
