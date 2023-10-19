// Parsing with TryParse
class Program {
    static void Main()
    {
        string myString = "351";
        int parseResult = int.Parse(myString);
        Console.WriteLine(parseResult); // 351

        bool statusParsing = int.TryParse(myString, out int result);
        Console.WriteLine(result);      // 351
        Console.WriteLine(statusParsing);   // true
    }
}