//var, object, dynamic
class Program
{
    static void Main() 
    {
        void Printer(object x) {
            Console.WriteLine(x);
        }

        void Add(object x, object y)
        {
            if(x is int && y is int) {
                int a = (int)x;
                int b = (int)y;
                Console.WriteLine((a+b));
            }
            if(x is Car) {
                Console.WriteLine("Tidak masuk akal");
            }
        }

        //var = compiler help decide variable type
        var myInt = 3;	
        myInt = int.Parse("1");
        Console.WriteLine(myInt);
        
        // object -> tidak typesafety
        int myInt2 = 2;
        object x = myInt2;
        Console.WriteLine(x);
        
        int myInt3 = 3;
        object obj = myInt3; // Boxing
        float result = (int)obj; // Unboxing
        
        Printer(3);
        Printer("a");
        Printer(true);
        Printer(3.0f);
        Printer(3.0M);
        
        Add(3,3);
        Add(new Car(), new Car());
        
        //dynamic (dont use it) -> apapun bisa masuk, error ketahuan setelah program jalan
        dynamic myDynamic = 3;
        myDynamic = "3";
        myDynamic = true;
        myDynamic = new Car();
        myDynamic.CallIstriGuwe();
        myDynamic.Mboh();
        myDynamic.EngineRunButBurnKetoke();
    }
}

class Car{

}
