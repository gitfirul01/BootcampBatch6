using Animal;

class Program
{
	public static void Main()
	{
		Cat oyen = new Cat();
		oyen.colour = "orange";
		oyen.leg = 4;
		oyen.isTailLong = false;
		oyen.weight = 200;
		oyen.height =2;
		Console.WriteLine(oyen.colour);
		Console.WriteLine(oyen.leg);
		
		Cat bambang = new Cat();
		oyen.colour = "black";
		oyen.Jump();
	}
}