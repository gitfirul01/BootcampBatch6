namespace Transportation;
public class Car
{
	//variable
	public string brand;
	public string type;
	public int door;
	
	//constructior
	public Car(string brand, string type, int door)
	{
		this.brand = brand;
		this.type = type;
		this.door = door;
		
		Console.WriteLine(
			$"Created a new car object\n\tBrand: {this.brand}\n\tType: {this.type}\n\tDoor: {this.door}"
			);
	}
	
	//method
	
}
