/*
	Property
*/

class Car {
	//variable
	public string name = "";
	private int _age;
	private int _balance;
	
	//constructor
	public Car(int age) {
		_age = age;
	}
	
	//property:	<access mod> <return/data type> <Name> {get; set;}
	// public string Type {get; set;}
	// public string Type {get; private set;}
	// public string Type {private get; set;}
	public string Type {
		get {
			return Type;
		}
		set {
			if (value != null) {
				Type = value;
			}
		}
	}

	public int Balance {
		get {
			return _balance * 1000;
		}
		set {
			if(value > 0) {
				_balance = value;
			}
		}
	}
}

class Program
{
	static void Main()
	{
		Car car = new(10);
		car.Balance = 20;
		Console.WriteLine(car.Balance);
	}
}