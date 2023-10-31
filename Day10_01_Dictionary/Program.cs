// Dictionary

class Program {
	static void Main()
	{
		Dictionary<int,string> myDict = new();
		myDict.Add(3,"foo");
		myDict.Add(5,"bar");
		// myDict.Add(3,"fizz"); 	// ERROR: Key must be unique
		myDict.Add(7,"foo"); 		// Value bebas

		foreach(KeyValuePair<int,string> e in myDict) {
			Console.WriteLine($"{e.Key} {e.Value}");
		}


		// mengambil nilai (value) dari key
		string myValue = myDict[3];
		Console.WriteLine(myValue);
		

		// mencari key dari value yang diketahuii
		string valueForSearch = "foo";
		int keyResult = 0;

		foreach(var e in myDict) {
			if(e.Value == valueForSearch) {
				keyResult = e.Key;
				break;
			}
		}
		Console.WriteLine(keyResult);


		// Memeriksa elemen dictionary
		// Contains -> KeyValuePair
		// ContainsKey() -> value key
		// ContainsValue() -> value of value
		KeyValuePair<int,string> keysvalue = new(3,"foo");
		bool checkKey = myDict.Contains(keysvalue);
		Console.WriteLine(checkKey);


		// Mengubah nilai
		myDict[3] = "buzz";


		// TryAdd: mencoba menambahkan, jika sudah ada, maka tidak akan ditambahkan
		int keyAdd = 3;
		string valueAdd = "yanto";
		myDict.TryAdd(1, "yanto"); //TryAdd 
		foreach (KeyValuePair<int, string> e in myDict)
		{
			Console.WriteLine($"{e.Key} {e.Value}");
		}
	}
}