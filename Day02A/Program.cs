using Animal;
using Transportation;

class Program
{
	static void Main()
	{
		Car toyota = new Car();
		Console.WriteLine(toyota.EngineStart(true));
		toyota.Move("left");
		
		Cat oyen = new();
		oyen.Run();
	}
}