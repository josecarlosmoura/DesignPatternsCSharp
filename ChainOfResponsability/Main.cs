using ChainOfResponsability.Exercise;

namespace ChainOfResponsability
{
	public static class Main
	{
		public static void Execute()
		{
			GenerateChain generateChain = new GenerateChain();

			BankAccount bankAccount = new BankAccount(500, "My Name");

			string format = generateChain.Generate(Format.CSV, bankAccount);

			Console.WriteLine(format);
		}
	}
}
