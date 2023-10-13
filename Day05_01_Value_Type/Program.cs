/* 
 * VALUE TYPE
 * value type terdiri dari tipe data primitive (non-user-defined): int, long, short, bool, double, float, char, decimal, struct
 * nilai value type akan disimpan pada stack memory -> First In Last Out
 * ketika value type di-assign, maka yang akan di-passing adalah value-nya
 */
class Program {
    static void Main()
    {
        int a = 3; // a = 3
        int b = a; // b = a = 3
        b = 5;     // b = 5
        
        Console.WriteLine(a); // 3
        Console.WriteLine(b); // 5
    }
}