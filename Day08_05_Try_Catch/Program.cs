//Exception (try - catch)
using System.Data;

class Program {
    static void Main()
    {
        void Caller(ref int x)
        {
            Console.WriteLine("Caller called");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            x = a/b;
            Console.WriteLine("Caller finish");
        }

        Console.WriteLine("Start");
        int x = 0;
        try {
            Caller(ref x);
        }
        catch(Exception e) {
            throw new EvaluateException();
        }
        finally {
            Console.WriteLine("release resource");
        }
        Console.WriteLine(x);
        Console.WriteLine("Finish all task");
    }
}
