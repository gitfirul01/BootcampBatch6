/* GetInvocationList (return string)
	- GetInvocationList berfungsi untuk membongkar isi delegate (melihat method apa saja yang ada di dalamnya)
*/
public delegate string MyDelegate();

class Program {
	static void Main() {
		string Message() { return "message"; }
		string PrintOut() { return "printout"; } 

		MyDelegate mydel = Message;
		mydel += PrintOut;
		
		List<string> result = new();
		Delegate[] delegateList = mydel.GetInvocationList();
		
		foreach(MyDelegate d in delegateList) {
			result.Add(d.Invoke());
		}
		Console.WriteLine(result);
	}
}

// You can define other methods, fields, classes and namespaces here