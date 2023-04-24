using Domain;
using Domain.Interfaces;

namespace ChainOfResponsability.DiscountRules
{
	public class ItemQuantityDiscount : IDiscount
	{
        public IDiscount Next { get; set; }

        public double ApplyRule(Buget buget)
		{
			if (buget.Itens.Count > 5)
			{
				return buget.Value * 0.01;
			}

			return Next.ApplyRule(buget);
		}
	}
}
