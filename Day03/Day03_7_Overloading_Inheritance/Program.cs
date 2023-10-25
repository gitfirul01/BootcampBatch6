﻿/*
    Overloading + Inheritance
*/
class Program {
    static void Main() {
        Child c1 = new();
        Child c2 = new("anak", "papa");
    }
}

class Parent {
    private string _name;
    public Parent(){
        _name = "papa";
    }
    public Parent(string name){
        _name = name;
    }
}

class Child:Parent {
    public Child(string name){

    }
    public Child(string name, string parentName):base(parentName){

    }
    public Child():base("parent"){

    }
}