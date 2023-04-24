using Strategy.Exercise.Interfaces;

namespace Strategy.Exercise.IvestmentPofiles
{
	public class Conservative : IInvest
	{
		public double MakeInvestment(double value)
		{
			return value * 0.008;
		}
	}
}
