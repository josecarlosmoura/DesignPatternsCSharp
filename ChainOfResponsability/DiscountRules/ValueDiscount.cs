using Domain;
using Domain.Interfaces;

namespace ChainOfResponsability.DiscountRules
{
	public class ValueDiscount : IDiscount
	{
        public IDiscount Next { get; set; }

        public double ApplyRule(Buget buget)
		{
			if (buget.Value > 500.0)
			{
				return buget.Value * 0.07;
			}

			return Next.ApplyRule(buget);
		}
	}
}
