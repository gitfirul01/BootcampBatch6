/*
	Property
*/

class Car {
	// variable
	public string name = "";
	private int _age;
	private int _balance;
	
	// constructor
	public Car(int age) {
		_age = age;
	}
	
	// Property: <access mod> <return/data type> <Name> {get; set;}
	public int Age {
		get {
			return _age;
		}
		set {
			_age = value;
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

	/* Automatic Property: compiler akan secara implisit membuat private field/variabel Age */
	// public int Age {get; set;}
	// public int Age {get; private set;}
	// public int Age {private get; set;}
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