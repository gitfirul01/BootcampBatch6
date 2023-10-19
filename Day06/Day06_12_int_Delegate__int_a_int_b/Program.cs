﻿/*
	Delegate
		- secara default hanya akan me-return value dari method terakhir
*/

public delegate int MyDelegate(int left, int right); //wadah dari method

class Program
{
	static void Main()
	{
		MyDelegate myDelegate = Add;
		myDelegate += Multiply;

		int result = myDelegate(3,5); // Invoke
		Console.WriteLine(result); // 15
	}
	static int Add(int left, int right)
	{
		return left+right;
	}
	static int Multiply(int left, int right)
	{
		return left*right;
	}
}