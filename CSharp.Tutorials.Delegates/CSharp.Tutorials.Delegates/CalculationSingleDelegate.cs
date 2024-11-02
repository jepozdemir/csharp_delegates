public class CalculationSingleDelegate
{
	public delegate void Calculation(int num1, int num2);

	static void Calculate(int num1, int num2, Calculation calculation)
	{
		calculation(num1, num2);
	}

	static void Multiply(int a, int b)
	{
		Console.WriteLine($"Multiply of {a} and {b} is : {a * b}");
	}

	void Add(int a, int b)
	{
		Console.WriteLine($"Sum of {a} and {b} is : {a + b}");
	}

	public static void Test()
	{
		// Instance method must be access through object
		CalculationSingleDelegate p = new CalculationSingleDelegate();
		Calculate(5, 2, p.Add);

		// Static method
		Calculate(5, 2, Multiply);
	}
}