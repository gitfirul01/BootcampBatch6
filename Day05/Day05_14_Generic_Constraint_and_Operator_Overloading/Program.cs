﻿// Generic Constraint ( where T : bla bla bla )

using System.Numerics;
class Program {	
	void Main()
	{
		Combiner<int> combine = new();
		combine.Add(3,4);

		Combiner<Car> combineCar = new();
		Car result = combineCar.Add(new Car(2000), new Car(3000));
		Console.WriteLine(result.GetPrice()); // 5000
		
		Car carA = new Car(1000);
		Car carB = new Car(2000);
		Car carTotal = carA + carB;
		Console.WriteLine(carTotal.GetPrice()); // 3000
		
		Car divideCar = carB - carA;
		Console.WriteLine(divideCar.GetPrice()); // 1000
	}
}

class Combiner<T> where T : IAdditionOperators<T,T,T> 
{
	public T Add(T a, T b) {
		return a + b;
	}
}
class Car : IAdditionOperators<Car, Car, Car>
{
	private int _price;
	public Car(int price) {
		_price = price;
	}
	public int GetPrice() {
		return _price;
	}
	public static Car operator +(Car left, Car right) //Operator Overloading
	{
		return new Car(left.GetPrice() + right.GetPrice());
	}
	public static Car operator -(Car left, Car right) //Operator Overloading
	{
		return new Car(left.GetPrice() - right.GetPrice());
	}
}