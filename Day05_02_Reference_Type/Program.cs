/* 
 * REFERENCE TYPE
 * reference type terdiri dari tipe data user-defined: string, array, list, dict
 * nilai reference type akan disimpan pada heap memory, sedangkan address-nya akan disimpan di stack memory
 * ketika reference type di-assign, maka yang akan di-passing adalah address-nya
 */
class Program
{
    static void Main()
    {
        // string x = "3";
        Car car1 = new Car(3);  // car1_address = *address1                 | address1_memory_value = 3 
        Car car2 = car1;        // car2_address = car1_address = *address1  | address1_memory_value = 3 
        car2.value = 5;         // car2.value = 5 -> *address1.value = 5    | address1_memory_value = 5
        
        Console.WriteLine(car1.value);  // 5 -> address1_memory_value = 5
        Console.WriteLine(car2.value);  // 5 -> address1_memory_value = 5

        // Car car3 = new Car(5);
        // car3 = car1;
    }
}

class Car {
	public int value;
	public Car(int x) {
		value = x;
	}
}
