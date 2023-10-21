using Transportation;
using CarComponent;

class Program
{
	static void Main()
	{
		Engine diesel = new Engine("diesel", 2002);
		Tire hancock = new Tire("hancock", 2002);
		Lamp osram = new Lamp("osram", 2003);
		
		Car toyota = new Car("Toyota", "Kijang", diesel, hancock, osram);
	}
}