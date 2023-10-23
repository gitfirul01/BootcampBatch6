class Program {
    static void Main() {
        List<int> myInt = new List<int> {1, 2, 3};
        var enumerable = myInt.GetEnumerator();

        enumerable.MoveNext(); // now index = 0 (start at index = -1)
        enumerable.MoveNext(); // now index = 1
        enumerable.MoveNext(); // now index = 2
        int result = enumerable.Current;
        Console.WriteLine(result);
    }
}