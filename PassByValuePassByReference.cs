// C# program to illustrate the
// concept of ref parameter
using System;

class Pass
{

	// Main Method
	public static void Main()
	{

		// Assign string value
		string str = "Numan";

		// Pass as a reference parameter
		SetValue(ref str);

		// Display the given string
		Console.WriteLine(str);
	}

	static void SetValue(ref string str1)
	{

		// Check parameter value
		if (str1 == "Numan")
		{
			Console.WriteLine("Hello!!Numan	");
		}

		// Assign the new value
		// of the parameter
		str1 = "Numan1121";
	}
}
