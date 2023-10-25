/*
    POLYMORPHISM: Override + Method Hiding
    - Pada override, method parent class ter-replace oleh method child class
    - Sedangkan pada method hiding, method parent class masih tersimpan pada memory

    - untuk melakukan override:
        > menggunakan keyword 'virtual' di base class
        > menggunakan keyword 'override' di child class
*/
class Program {
    static void Main() {
        // Inherite
        Dog dog = new();
        dog.MakeSound();        // Make Sound

        Animal parent1 = dog;
        parent1.MakeSound();    // Make Sound

        // Override
        Cat cat = new();
        cat.MakeSound();        // Meow
        
        Animal parent2 = cat;
        parent2.MakeSound();    // Meow: sudah ter-override (ter-replace)

        // Method Hiding
        Bird bird = new();
        bird.MakeSound();       // Chip
        Animal parent3 = bird;
        parent3.MakeSound();    // Make Sound
    }
}

class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("Make Sound");
    }
}

class Dog:Animal {
    // idem (inherite) 
}

class Cat:Animal {
    // overriding
    public override void MakeSound() {
        Console.WriteLine("Meow");
    }
}

class Bird:Animal {
    // method hiding
    public new void MakeSound() {
        Console.WriteLine("Chip");
    }
}

class Ant {

}