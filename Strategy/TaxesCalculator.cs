using Domain;
using Domain.Interfaces;

namespace Strategy
{
	public class TaxesCalculator
	{
		public void DoCaltulation(Buget buget, ITax tax)
		{
			double value = tax.Calculate(buget);
			Console.WriteLine(value);
		}
	}
}
