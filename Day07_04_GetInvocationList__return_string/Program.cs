//GetInvocationList (return string)
public delegate string MyDelegate();
void Main()
{
	MyDelegate mydel = Message;
	mydel += PrintOut;
	
	List<string> result = new();
	Delegate[] delegateList = mydel.GetInvocationList();
	foreach(MyDelegate d in delegateList) {
		result.Add(d.Invoke());
	}
	result.Dump();
}

string Message() {
	return "message";
}
string PrintOut() {
	return "printout";
} 

// You can define other methods, fields, classes and namespaces here