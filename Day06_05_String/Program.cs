// String
class Program {
    static void Main()
    {
        void StringAppender(ref string input)
        {
            input = input + "!!!!";
        }

        string myString = "Hello";

        /* string merupakan reference type, namun memiliki kecenderungan seperti value type.
           atau dengan kata lain string adalah value type yang disimpan di heap memory */
        StringAppender(ref myString);
        Console.WriteLine(myString);
    }
}    

