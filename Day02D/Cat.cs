namespace LivingBeing;

public class Cat:Animal
{
	//constructor
	public Cat(string parentName, string name) : base(parentName)
	{
		Console.WriteLine($"Cat instance created: {name}");
		this.name = name;
	}
	//method
	public void Jump()
	{
		Console.WriteLine("Jump");
	}
	public void Meow()
	{
		Console.WriteLine("Meow");
	}
}
