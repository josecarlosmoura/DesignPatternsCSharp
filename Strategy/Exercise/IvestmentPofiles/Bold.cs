using Strategy.Exercise.Interfaces;

namespace Strategy.Exercise.IvestmentPofiles
{
	public class Bold : IInvest
	{
		public double MakeInvestment(double value)
		{
			int probability = new Random().Next(101);

			if (probability <= 20)
			{
				return value * 0.05;
			}
			else if (probability > 20 && probability <= 30)
			{
				return value * 0.03;
			}
			else
			{
				return value * 0.006;
			}
		}
	}
}
