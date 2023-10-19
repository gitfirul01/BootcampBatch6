/*
	Delegate
		- dapat menyimpan method dengan karakteristik yang serupa (return value dan argumen -nya)
		- akan mengeksekusi method dari yang pertama di daftarkan, sampai yang terakhir di daftarkan
*/

public delegate void MyDelegate(); // delegate: wadah dari method

class Program {
	static void Main() {
		MyDelegate myDelegate = Printer;	// buat instance
		myDelegate += Layangan;
		myDelegate += Printer2;
		myDelegate += Layangan2;
		
		myDelegate(); // Invoke (panggil)
	}
	static void Printer() {
		Console.WriteLine("Printer");
	}
	static void Layangan() {
		Console.WriteLine("Layangan");
	}
	static void Printer2()
	{
		Console.WriteLine("Printer");
	}
	static void Layangan2()
	{
		Console.WriteLine("Layangan");
	}
}