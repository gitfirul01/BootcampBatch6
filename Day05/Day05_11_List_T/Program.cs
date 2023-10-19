/* List Collection / Generic with Abstraction
	- List adalah salah satu built in generic class di C#
		public class List<T> {}
*/

class Program {
	static void Main()
	{
		List<ITransport> myList = new List<ITransport>();
		myList.Add(new Car());
		myList.Add(new Truck());
		myList.Add(new Plane());
		// myList.Add(new Sayur()); // ERROR karena tidak mengaplikasikan kontrak ITransport
	}
}

public interface ITransport { }
class Car : ITransport{ }
class Truck : ITransport { }
class Plane : ITransport { }
class Sayur { }