using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.DiscountRules
{
	public class NoDiscount : IDiscount
	{
		public IDiscount Next { get; set; }

		public double ApplyRule(Buget buget)
		{
			return 0;
		}
	}
}
