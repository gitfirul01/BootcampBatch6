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

        // Console.WriteLine(carA.StaticPrice); // ERROR: static variable tidak dapat diakses oleh instance secara langsung
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