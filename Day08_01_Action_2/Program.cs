// Action
class Program {
    static void Main() {
        void Printer(string message) {
            Console.WriteLine($"print: {message}");
        }

        void Update(string update) {
            Console.WriteLine($"update: {update}");;
        }

        Action<string> act = null;

        act += Printer;
        act += Update;

        act?.Invoke("hello"); //without ? will be exception
    }
}
