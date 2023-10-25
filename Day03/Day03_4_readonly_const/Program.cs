/*
	(default) int
	readonly int
	const int
*/
class Car {
	public string brand;
	public readonly int price;
	public const int tire = 4;	// const harus langsung dideklarasi
	
	public Car(string brand, int price) {
		this.brand = brand;
		this.price = price;	// readonly hanya bisa dideklarasi pada constructor
		// this.tire = 3;	// ERROR: const hanya bisa dideklarasi di field
	}
	
	/* READONLY FIELD CANNOT BE ASSIGNED */
	// public void SetPrice(int num) 
	// {
	// 	price = num;
	// }
}

class Program {
	static void Main(){
		Car car = new Car("Toyota", 1000);
		
		Console.WriteLine(car.brand);	// Toyota
		car.brand = "Honda";
		Console.WriteLine(car.brand);	// Honda
		
		Console.WriteLine(car.price);
		// car.price = 3; 				// ERROR: readonly
		
		// Console.WriteLine(car.tire);	// ERROR: const bersifat static, jadi untuk memanggilnya harus menggunakan nama class (type) nya
		Console.WriteLine(Car.tire);
		// car.tire = 3; 				// ERROR: const readonly
	}
}
