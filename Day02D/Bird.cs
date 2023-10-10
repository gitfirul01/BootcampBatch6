namespace LivingBeing;

public class Bird:Animal
{
	//constructor
	public Bird(string parentName, string name) : base(parentName)
	{
		Console.WriteLine($"Bird instance created: {name}");
		this.name = name;
	}
	//method
	public void Fly()
	{
		Console.WriteLine("Fly");
	}
	public void Chip()
	{
		Console.WriteLine("Chip");
	}
}
