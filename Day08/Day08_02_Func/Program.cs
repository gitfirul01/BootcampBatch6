//Func
class Program {
    static void Main()
    {
        int Add(int a, int b) {
            return a + b;
        }

        string Message(string a, int b, bool c) {
            return "test";
        }

        Func<int, int, int> func = Add;
        Func<string, int, bool, string> func2 = Message;

        Console.WriteLine(func?.Invoke(1, 2));
        Console.WriteLine(func2?.Invoke("a", 1, true));
    }
}