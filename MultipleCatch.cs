// C# program to illustrate the
// use of multiple catch block
using System;

class GFG
{

	// Main Method
	static void Main()
	{

		// Here, number is greater than divisor
		int[] number = { 8, 17, 24, 5, 25 };
		int[] divisor = { 2, 0, 0, 5 };

		// --------- try block ---------

		for (int j = 0; j < number.Length; j++)

			// Here this block raises two different
			// types of exception, i.e. DivideByZeroException
			// and IndexOutOfRangeException
			try
			{

				Console.WriteLine("Number: " + number[j]);
				Console.WriteLine("Divisor: " + divisor[j]);
				Console.WriteLine("Quotient: " + number[j] / divisor[j]);
			}

			// Catch block 1

			// This Catch block is for
			// handling DivideByZeroException
			catch (DivideByZeroException)
			{

				Console.WriteLine("Not possible to Divide by zero");
			}

			// Catch block 2

			// This Catch block is for
			// handling IndexOutOfRangeException
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Index is Out of Range");
			}
	}
}

