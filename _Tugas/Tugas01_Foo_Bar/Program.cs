class Program {
    static void Main(){
        int n;
        string output = "";

        Console.Write("n: ");
        n = Int32.Parse(Console.ReadLine());

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
        Console.WriteLine(output);
    }
}