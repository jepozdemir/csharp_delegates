public class SingleDelegate
{
	public delegate void PrintMessage(string message);

	static void Print(string message)
	{
		Console.WriteLine(message);
	}

	public static void Test()
	{
		PrintMessage printer = Print;
		printer("Hello from delegate!");
	}
}
