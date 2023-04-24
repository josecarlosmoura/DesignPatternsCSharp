using Strategy.Exercise.Interfaces;

namespace Strategy.Exercise.IvestmentPofiles
{
	public class Moderate : IInvest
	{
		public double MakeInvestment(double value)
		{
			int probability = new Random().Next(101);
			
			if (probability > 50)
			{
				return value * 0.007;
			}

			return value * 0.025;
		}
	}
}
