using ChainOfResponsability.DiscountRules;
using Domain;
using Domain.Interfaces;

namespace ChainOfResponsability
{
	public class DiscountCalculator
	{
		public double Calculate(Buget buget)
		{
			IDiscount discountOne = new ItemQuantityDiscount();
			IDiscount discountTwo = new ValueDiscount();
			IDiscount discountThree = new DiscountPerMarriedSale();
			IDiscount discountFour = new NoDiscount();

			discountOne.Next = discountTwo;
			discountTwo.Next = discountThree;
			discountThree.Next = discountFour;

			return discountOne.ApplyRule(buget);
		}
	}
}