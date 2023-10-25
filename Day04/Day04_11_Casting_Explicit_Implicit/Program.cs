// int float double
class Program {
	static void Main()
	{
		int a = 1;
		int b = 2;
		int c = 3;
		Console.WriteLine(a+b == c); // True
		
		float fa = 1.0f;
		float fb = 2.0f;
		float fresult = fa + fb;
		float fc = 3.0f;
		Console.WriteLine(fresult == fc); // True

		double da = 0.1;
		double db = 0.2;
		double result = da + db;
		double dc = 0.3;
		Console.WriteLine(result == dc); //False: double tidak begitu akurat untuk operasi desimal
		Console.WriteLine(result);

		decimal DA = 1.0M;
		decimal DB = 2.0M;
		decimal DC = 3.0M;
		Console.WriteLine(DA+DB == DC); // True
	}
}