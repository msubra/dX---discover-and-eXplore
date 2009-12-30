using System;

public class MulTest
{
	static void multiply(int x, int y, out int z)
	{
		z = x * y;
	}

	public static void Main()
	{
		Console.Write("Enter a number:");
		int x = long.Parse(Console.ReadLine());

		Console.Write("Enter a number:");
		int y = long.Parse(Console.ReadLine());

		int z;
		multiply(x,y,z);
		Console.WriteLine("{0} x {1} = {2}",x,y,z);


	}
}