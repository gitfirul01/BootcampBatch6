/*
	Protected Level Access Modifier
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
	public int AGE = 10;
}

public class Cat:Animal
{
	public int GetAge()
	{
		// return _age;	// ERROR: inaccessible due to its protection level
		return Age;	// bisa diakses karena diturunkan ke anaknya
		// return AGE;	// publik
	}
}
