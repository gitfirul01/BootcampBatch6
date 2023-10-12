﻿/*
    Abstract class and abstract method
*/
class Program {
    static void Main() {
        Child c = new Child();
        Console.WriteLine(c.d);

        Parent p = c;
        Console.WriteLine(p.a);
    }
}

abstract class Parent {
    public int a = 1;
    public int b = 2;
    public abstract void MethodX(); // abstract class with no implementation
    public void MethodY(){
        // implementation
    }
}

class Child:Parent {
    public int c = 3;
    public int d = 4;

    public override void MethodX()
    {
        // implementation
    }
}