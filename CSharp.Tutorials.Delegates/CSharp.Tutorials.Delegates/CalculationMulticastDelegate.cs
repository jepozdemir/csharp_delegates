public class CalculationMulticastDelegate
{
	// Declare a delegate with a return type
	public delegate int Calculation(int num);

	// Method that doubles the number
	static int Double(int num)
	{
		Console.WriteLine($"Double of {num} is {num * 2}");
		return num * 2;
	}

	// Method that triples the number
	static int Triple(int num)
	{
		Console.WriteLine($"Triple of {num} is {num * 3}");
		return num * 3;
	}

	public static void Test()
	{
		// Instantiate the delegate and bind it to the Double method
		Calculation calc = new Calculation(Double);

		// Add the Triple method to the delegate invocation list
		calc += Triple;

		// Invoke the multicast delegate
		int result = calc(5);

		Console.WriteLine($"Final returned result: {result}");
	}
}