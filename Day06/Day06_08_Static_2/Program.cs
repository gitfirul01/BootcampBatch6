// Static
class Program {
    static void Main() {
        Car carA = new Car();
        Car carB = new Car();
        carB.PriceHandler(10);  // static variable dapat diakses melalui instance method
        carA.PriceHandler(11);
        
        Console.WriteLine(carA.GetPrice()); // static variable dapat diakses melalui instance method
        Console.WriteLine(carB.GetPrice());
        Console.WriteLine(Car.StaticPrice);

        // Console.WriteLine(carA.StaticPrice); // ERROR: static variable harus diakses menggunakan type, bukan instance
    }
}

class Car {
	public static int StaticPrice;
	
	public void PriceHandler(int price) {
		StaticPrice = price;
	}
	public int GetPrice()
	{
		return StaticPrice;
	}
}