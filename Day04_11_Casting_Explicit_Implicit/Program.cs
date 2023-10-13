// int float double
void Main()
{
	int a = 1;
	int b = 2;
	int c = 3;
	Console.WriteLine(a+b == c); // True
	
	float fa = 1.0f;
	float fb = 2.0f;
	float fresult = 1.0f + 2.0f;
	float fc = 3.0f;
	Console.WriteLine(fresult == fc); // True

	double da = 0.1;
	double db = 0.2;
	double result = a + b;
	Console.WriteLine(a + b == 0.3); //False
	Console.WriteLine(result);

	decimal DA = 1.0M;
	decimal DB = 2.0M;
	decimal DC = 3.0M;
	Console.WriteLine(DA+DB == DC); // True
}

// You can define other methods, fields, classes and namespaces here