// Program.cs
class Program {
    static void Main(){
        int n = 15;
        string result;

        result = FooBar.Run(n);
        Console.WriteLine(result);
    }
}


// FooBar.cs
static class FooBar {
    public static string Run (int n) {
        string output = "";
        for (int i=0; i<=n; i++) {
            if ((i == 0) || ((i%3 != 0) && (i%5 != 0))) {
                output += i.ToString();
            }
            else {
                if (i % 3 == 0) {
                    output += "Foo";
                }
                if (i % 5 == 0) {
                    output += "Bar";
                }
            }
            if (i != n) {
                output += ", ";
            }
        }
        return output;
    } 
}