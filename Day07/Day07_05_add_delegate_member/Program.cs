//+=
public delegate string MyDelegate();

class Program {
	static void Main()
	{
		string Message() { return "message"; }
		string PrintOut() { return "printout"; }

		MyDelegate mydel = Message;
		MyDelegate mydel2 = PrintOut;
		MyDelegate result = mydel + mydel2;

		MyDelegate mydelll = Message;
		mydelll += PrintOut;
	}
}

// You can define other methods, fields, classes and namespaces here