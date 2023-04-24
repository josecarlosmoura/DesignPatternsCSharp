using Domain;
using Domain.Interfaces;

namespace Strategy
{
	public class ICCC : ITax
	{
		public double Calculate(Buget buget)
		{
			if (buget.Value < 1000.0)
			{
				return buget.Value * 0.05;
			}
			
			if (buget.Value <= 3000.0)
			{
				return buget.Value * 0.07;
			}

			return buget.Value * 0.08 + 30.0;
		}
	}
}
