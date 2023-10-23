class Program {
    static void Main() {
        // Car cara = new Car(3);
        // Car carb = cara;
        // bool result = cara == carb;
        // Console.WriteLine(result);

        Car cara = new Car(3);
        Car carb = new Car(5);
        Yusuf y = new Yusuf();
        bool result = cara.Equals(y);
        Console.WriteLine(result);
    }
}

class Yusuf {}
class Car {
    public int CarId {get; private set;}
    public Car(int id) {
        CarId = id;
    }
    public override bool Equals(object obj)
    {
        if (obj is Car y)
        {
            var car = obj as Car;
            return CarId == y.CarId;
        }
        return false;
    }
}
