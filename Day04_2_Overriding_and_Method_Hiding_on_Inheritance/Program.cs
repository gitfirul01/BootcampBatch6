class Program{
    static void Main(){
        // Engine general = new DieselEngine();

        // Engine e = new Engine();
        // DieselEngine diesel = new DieselEngine()
        // e = diesel;

        DieselEngine diesel = new();
        ElectricEngine electric = new();

        Car car1 = new(diesel);
        Car car2 = new(electric);

        car1.EngineStart();
        car2.EngineStart();
    }
}


class Car{
    private Engine _engine;

    public Car(Engine e){
        _engine = e;
    }

    public void EngineStart(){
        _engine.Run();
        _engine.WarmUp();
    }
}

class Engine {
    public virtual void Run() {
        Console.WriteLine("Engine Run");
    }
    public void WarmUp(){
    }
}

class DieselEngine:Engine {
    // Inheritance: Overriding
    public override void Run() {
        Console.WriteLine("Diesel Engine Run");
    }
    // Inheritance: Method Hiding
    public void WarmUp(){
        Console.WriteLine("Diesel Engine Warm Up");
    }
}

class ElectricEngine:Engine {
    // Inheritance: Method Hiding
    public void Run() {
        Console.WriteLine("Electric Engine Run");
    }
}