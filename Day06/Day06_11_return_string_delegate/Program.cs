/*
	Delegate
		- dapat digunakan oleh method yang memiliki return value
		- value dari method yang di return adalah yang terakhir didaftarkan
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