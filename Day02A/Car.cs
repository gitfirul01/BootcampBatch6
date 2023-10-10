namespace Transportation;

public class Car
{
	public string color = "";
	public int door;
	public int wheel;
	
	public string EngineStart(bool status)
	{
		if (status)
		{
			return "Engine Start";	
		}
		else
		{
			return "Engine Stop";	
		}
	}
	public void Move(string direction)
	{
		Console.WriteLine(direction);
		//string concat
		Console.WriteLine("Car move to "+direction+" now");
		//string interpolation
		Console.WriteLine($"Car move to {direction} now");
		Console.WriteLine($"\tCar move to\n{direction} now");
	}
}
