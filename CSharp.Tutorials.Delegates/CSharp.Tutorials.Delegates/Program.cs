class Program
{
	static void Main()
	{
		Console.WriteLine("\r\nSingle Delegates :\r\n");
		SingleDelegate.Test();
		CalculationSingleDelegate.Test();

		Console.WriteLine("\r\nMulticast Delegates :\r\n");
		MulticastDelegate.Test();
		CalculationMulticastDelegate.Test();
	}
}