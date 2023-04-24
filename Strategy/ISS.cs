using Domain;
using Domain.Interfaces;

namespace Strategy
{
	public class ISS : ITax
	{
		public double Calculate(Buget buget)
		{
			return buget.Value * 0.06;
		}
	}
}
