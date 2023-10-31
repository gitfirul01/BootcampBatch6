/* Generic Collector
	- Gemeric <...> : membuat template untuk tipe data tertentu
	- terdapat dua macam generic:
		1. Generic Class
				class Name<T> { }
		2. Generic Method
				void Name<T>()
	- membuat satu generic class / method sebagai wadah, kemudian menentukan tipe datanya ketika class tersebut dibuat
*/
void Main()
{
	GenericCollection<int> collection = new();
	collection.Add(3);
	collection.Add(4);
	collection.Add(5);
	int result = collection.myCollection[0];
	Console.WriteLine(result);
	
	GenericCollection<bool> collectionOfBool = new();
	collectionOfBool.Add(true);
	collectionOfBool.Add(false);
	bool resultOfBool = collectionOfBool.myCollection[0];
	Console.WriteLine(resultOfBool);
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
}