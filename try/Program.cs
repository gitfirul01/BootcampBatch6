class Program {
    static void Main() {
        Stack<int> myStack = new();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Console.WriteLine(myStack.Pop());
    }
}