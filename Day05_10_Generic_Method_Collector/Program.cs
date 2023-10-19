// Generic Method Collector

class Program {
	static void Main()
	{
		GenericCollection<int> generic = new();
		generic.Add(3, "hello");
		Console.WriteLine(generic.Add(4, "true"));	// true

		Console.WriteLine(generic.myCollection[0]);	// 3
	}
}

class GenericCollection<T>
{
	public T[] myCollection = new T[100];
	public int counter = 0;

	public T2 Add<T2>(T input, T2 input2)	// tipe data untuk T2 akan otomatis terdefinisi
	{
		myCollection[counter] = input;
		counter++;
		return input2;
	}
}