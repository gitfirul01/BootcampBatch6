﻿/* Without Generic or Object
	- membuat object collector untuk tipe data tertentu (misal int)
	- lebih mudah ketika ingin meng-unboxing karena sudah tau tipe data-nya
	- namun akan kesulitan ketika ingin membuat object collector untuk berbagai macam tipe data (akan membuat banyak class)
*/

void Main()
{
	IntCollection collection = new();
	collection.Add(1);

	int result = (int)collection.myCollection[0];
	int result2 = (int)collection.myCollection[1];
}
class IntCollection
{
	public int[] myCollection = new int[100];
	public int counter = 0;

	public bool Add(int input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
}
class StringCollection
{
	public string[] myCollection = new string[100];
	public int counter = 0;

	public bool Add(string input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
}
class DoubleCollection
{
	public double[] myCollection = new double[100];
	public int counter = 0;

	public bool Add(double input)
	{
		myCollection[counter] = input;
		counter++;
		return true;
	}
}