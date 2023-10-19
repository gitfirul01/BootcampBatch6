/* Reference Type, why dont need Ref
    - ketika mem-passing argument berupa reference type, maka secara otomatis yang di-passing adalah address-nya (bukan value-nya)
*/
class Program {
    static void Main() {
        void MultiplyByTwoCar(Car input)
        {
            input.price = input.price * 2;
        }

        Car car = new Car(2000); //Reference Type, without pass reference 'ref' keyword
        MultiplyByTwoCar(car);
        Console.WriteLine(car.price); // 4000
    }
}

class Car {
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
