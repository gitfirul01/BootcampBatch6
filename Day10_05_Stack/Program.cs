//Stack
void Main()
{
	Stack<int> myStack = new();
	myStack.Push(3);
	myStack.Push(5);
	myStack.Push(7);
	myStack.Push(9);
	
	//foreach(var e in myStack) {
	//	e.Dump();
	//}
	//var enumerator = myStack.GetEnumerator();
	//enumerator.MoveNext();
	//"test".Dump();
	//enumerator.Current.Dump();
	
	myStack.Pop().Dump();
	myStack.Pop().Dump();
	myStack.Peek().Dump();
	myStack.Peek().Dump();
	myStack.Pop().Dump();
	myStack.Pop().Dump();
	myStack.Pop().Dump(); //Exception, data habis
}

