using CarComponent;
namespace Transportation;

public class Car
{
	public string brand;
	public string model;
	public Engine engine;
	public Tire tire;
	public Lamp lamp;
	
	public Car(string brand, string model, Engine engine, Tire tire, Lamp lamp)
	{
		this.brand = brand;
		this.model = model;
		this.engine = engine;
		this.tire = tire;
		this.lamp = lamp;
		
		Console.WriteLine("Car Object Created");
		Console.WriteLine($"\tBrand: {this.brand}");
		Console.WriteLine($"\tModel: {this.model}");
		Console.WriteLine($"\tEngine: {this.engine.type} ({this.engine.year})");
		Console.WriteLine($"\tTire: {this.tire.type} ({this.tire.year})");
		Console.WriteLine($"\tLamp: {this.lamp.type} ({this.lamp.year})");
	}
}
