// HashTable (dictionary, but not type safety)
using System.Collections;

class Program {
    static void Main()
    {
        Hashtable hashtable = new();
        hashtable.Add(3, 3.3f);
        hashtable.Add("5", "foo");
        hashtable.Add(true, false);

        foreach (var element in hashtable) {
            Console.WriteLine(element);
        }
    }
}