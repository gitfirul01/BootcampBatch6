/*
	Delegate
		- dapat digunakan oleh method yang memiliki return value
*/

public delegate string MyDelegate();

class Program
{
	static void Main()
	{
		MyDelegate myDelegate = Printer;
		myDelegate += Layangan;

		string result = myDelegate(); // Invoke
		Console.WriteLine(result);
	}
	static string Printer()
	{
		return "Printer";
	}
	static string Layangan()
	{
		return "Layangan";
	}
}