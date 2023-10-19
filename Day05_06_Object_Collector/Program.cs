/* Object Collector
	- keyword 'object' akan membuat enclosure untuk variabel (boxing) dan dapat menyimpan semua tipe data
	- namun ketika akan di-unboxing, harus diketahui kunci (tipe data)-nya agar tidak terjadi error
	- contoh
		int -(boxing)-> object -(unboxing int)-> int
		int -(boxing)-> object -(unboxing string)-> ERROR // salah kunci untuk unboxing 
*/
void Main()
{
	ObjectCollection collection = new();
	collection.Add(1);
	collection.Add(true);
	collection.Add(1.0f);
	collection.Add(null);
	collection.Add("yusuf");
	collection.Add(1000000M);
	
	int result = (int)collection.myCollection[0];
	int result2 = (int)collection.myCollection[1];
}
class ObjectCollection {
	public object[] myCollection = new object[100];
	public int counter = 0;
	
	public bool Add(object input) {
		myCollection[counter] = input;
		counter++;
		return true;
	}
}