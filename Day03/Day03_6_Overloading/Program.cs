/*
    Overloading
    - membuat beberapa fungsi dengan nama yang sama, namun memiliki argumen / input variable yang berbeda
        - nama harus sama
        - argumen harus beda
        - tipe data boleh beda
*/
class Calculator {
    public void Add() { // mehtod 1
        Console.WriteLine("None");
    }
    public void Add(int a, int b) { // method 2
        Console.WriteLine(a+b);
    }
    public void Add(int a, int b, int c) {  // method 3
        Console.WriteLine(a+b+c);
    }
    public void Add(string a, string b) {   // mehtod 4
        return a+b;
    }
}

class Program {
    static void Main(){
        Calculator calc = new();
        calc.Add(); // memanggil method 1
        calc.Add(3,4);  // memanggil method 2
        calc.Add(3,4,5);    // memanggil method 3
        Console.WriteLine(calc.Add("1","2"));   // memanggil method 4
    }
}