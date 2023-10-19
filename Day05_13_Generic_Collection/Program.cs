// Generic Collector
class Program {
	void Main()
	{
		// int generic collector
		GenericCollection<int> collection = new();
		collection.Add(3);
		collection.Add(4);
		collection.Add(5);
		int result = collection.Get(1);
		Console.WriteLine(result);

		// bool generic collector
		GenericCollection<bool> collectionOfBool = new();
		collectionOfBool.Add(true);
		collectionOfBool.Add(false);
		bool resultOfBool = collectionOfBool.myCollection[0];
		Console.WriteLine(resultOfBool);
	}
}

class GenericCollection<T>
{
	public T[] myCollection = new T[100];
	public int counter = 0;

	public bool Add(T input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
	public T Get(int x) {
		return myCollection[x];
	}
}