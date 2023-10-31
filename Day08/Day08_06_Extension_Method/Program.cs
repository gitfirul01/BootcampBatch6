/* Extension Method
    - extension method merupakan method static
    - extension method merupakan method dari suatu class/type, namun seolah2 dimiliki oleh class/type lain
    - extension method menggunakan 'this' sebagai parameter pertamanya

    "The 'this' keyword refers to the current instance of the class 
     and is also used as a modifier of the first parameter of an extension method."
     https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this

*/
class Program{
    static void Main()
    {
        "Hello".Cetak();
        3.Cetak();
        bool lebihBesar = 3.Dibandingkan(6);
        lebihBesar.Cetak();
    }
}

public static class MyCetak {
	public static void Cetak(this object input) {
		Console.WriteLine(input);
	}
	public static bool Dibandingkan(this int a, int b) {
		return a > b;
	}
}

