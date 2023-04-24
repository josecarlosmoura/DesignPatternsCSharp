namespace Domain.Interfaces
{
	public interface IDiscount
	{
		IDiscount Next { get; set; }

		double ApplyRule(Buget buget);
	}
}
