// Array with Abstraction

class Program {
	static void Main()
	{
		/* array interface ITransport hanya akan menyimpan semua variabel 
		   yang memenuhi kontrak ITransport */
		ITransport[] transportation = new ITransport[5];
		transportation[0] = new Truck();
		transportation[1] = new Plane();
		transportation[2] = new Car();
		// transportation[3] = new Sayur(); // ERROR: tidak mengaplikasikan kontrak ITransport
	}
}

public interface ITransport { }
class Car : ITransport { }
class Truck : ITransport { }
class Plane : ITransport { }
class Sayur { }