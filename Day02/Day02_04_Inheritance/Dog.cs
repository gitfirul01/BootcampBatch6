namespace LivingBeing;

public class Dog:Animal
{
	//constructor
	public Dog(string parentName, string name) : base(parentName)
	{
		Console.WriteLine($"Dog instance created: {name}");
		this.name = name;
	}
	//method
	public void Run()
	{
		Console.WriteLine("Run");
	}
	public void Bark()
	{
		Console.WriteLine("Bark");
	}
}
