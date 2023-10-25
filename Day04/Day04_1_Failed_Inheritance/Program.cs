class Program{
    static void Main(){
        DieselEngine diesel = new();
        ElectricEngine electric = new();

        Car car1 = new(diesel);
        // Car car2 = new(electric);   // ERROR: karena electric engine bukan merupakan bahan dari class Car
                                       // yang diminta pada constructor Car adalah type DieselEngine
        car1.EngineStart();
    }
}

class Car{
    private DieselEngine _engine;

    public Car(DieselEngine e){
        _engine = e;
    }

    public void EngineStart(){
        _engine.Run();
    }
}

class DieselEngine{
    public void Run() {
        Console.WriteLine("Diesel Engine Run");
    }
}

class ElectricEngine {
    public void Run() {
        Console.WriteLine("Electric Engine Run");
    }
}