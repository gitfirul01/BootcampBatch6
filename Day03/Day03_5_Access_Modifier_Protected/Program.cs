/*
	Protected Level Access Modifier
	- hanya bisa diakses oleh child class dan parent class itu sendiri
*/
public class Program
{
	public static void Main()
	{
		
	}
}

public class Animal
{
	private int _age = 10;
	protected int Age = 10;
	public int age = 10;
}

public class Cat:Animal
{
	public int GetAge()
	{
		// return _age;	// ERROR: private tidak diturunkan ke child class
		return Age;		// bisa diakses karena diturunkan ke child class
		return age;		// publik
	}
}
