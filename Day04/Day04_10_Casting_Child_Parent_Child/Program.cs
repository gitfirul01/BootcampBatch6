/*  Casting
	- implicit upcast
	- explicit downcast
*/

class Program {
	static void Main()
	{	
		// Child -> Parent -> Child
		Child c = new Child();
		Parent p = c;					// upcasting
		Child result = (Child)p;		// downcasting
		Console.WriteLine(result.x);
	}
}
class Parent { }
class Child : Parent { public int x = 3; }