public class MulticastDelegate
{
	public delegate void Notify();

	static void Method1()
	{
		Console.WriteLine("Method1 called");
	}

	static void Method2()
	{
		Console.WriteLine("Method2 called");
	}

	public static void Test()
	{
		Notify notify = Method1;
		notify += Method2;

		notify();
	}
}