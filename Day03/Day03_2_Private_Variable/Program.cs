/*
	Private Variable
*/
class Program {
	static void Main() {
		Cat cat = new Cat("oyen" , 4);
		Console.WriteLine(cat.name);	// oyen
		Console.WriteLine(cat.GetAge("pass"));	// 4
		cat.SetAge(5);
		Console.WriteLine(cat.GetAge("pass"));	// 5
		Console.WriteLine(cat.GetAge("..."));	// 0
	}
}

class Cat
{
	//attribute
	public string name; 	// -> tidak boleh menggunakan public variable di formulatrix 
	private int _catAge; 	// private variable
	
	//constructor
	public Cat(string name, int age)
	{
		this.name = name;
		_catAge = age;
	}
	
	// method
	public int GetAge(string password) 
	{
		if (password == "pass")
		{
			return _catAge;
		}
		else
		{
			return 0;
		}
	}

	public void SetAge(int age)
	{
		if (age > 0)
		{
			_catAge = age;
		} 
	}

	public void Jump()
	{
		Console.WriteLine("Jump");
	}

	protected void Eat()
	{
		Console.WriteLine("Eat");
	}
}