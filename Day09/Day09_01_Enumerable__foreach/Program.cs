class Program {
    static void Main() {
        // Array iterable
        int[] myArray = {1, 2, 3, 4, 5};
        foreach (int i in myArray) {
            Console.WriteLine(i);
        }

        // List iterable
        List<string> myList = new List<string>() {"a", "b", "c"};
        foreach (string str in myList) {
            Console.WriteLine(str);
        }

        List<Car> myCar = new List<Car>() {
            new Car("Toyota"),
            new Car("Suzuki"),
            new Car("Daihatsu")
        };
        foreach (Car car in myCar) {
            Console.WriteLine(car);
        }

    }
}


class Car {
    public string brand;
    public Car(string brand){
        this.brand = brand;
    }
}