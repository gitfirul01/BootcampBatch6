/* Constant is static global,
    therefore it can not be called from instance.
    It should be called dirrectly through it class
*/

class Program {
    static void Main()
    {
        MyMath math = new MyMath();
        // math.phi.Dump(); // ERROR: cant call static variable from instance
        
        Console.WriteLine(MyMath.phi);
    }
}
class MyMath {
	public const float phi = 3.14f; //Const is static
}