// Static
class Program {
    static void Main()
    {
        int a = 2;
        int b = 3;
        int result;

        result = Calculator.StaticAdd(a,b); // static method dapat dipanggil tanpa membuat instance
        Console.WriteLine(result);  // 5

        Calculator myCalc = new();
        result = myCalc.NonStaticAdder(a,b); // non-static method harus dibuat instance nya terlebih dahulu baru bisa di panggil
        Console.WriteLine(result);  // 5
    }
}

class Calculator {
    // static method
	public static int StaticAdd(int left, int right) {
		return left+right;
	}

    // non-static method
	public int NonStaticAdder(int left, int right) {
		return left+right;
	}
}

/* Static Class */
// static class Calculator {
//     static ...
//     static ...
//     static ...
//     // all must be static
// }