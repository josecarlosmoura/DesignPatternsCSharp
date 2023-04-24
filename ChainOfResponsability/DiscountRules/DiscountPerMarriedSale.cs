using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.DiscountRules
{
	public class DiscountPerMarriedSale : IDiscount
	{
		public IDiscount Next { get; set; }

		public double ApplyRule(Buget buget)
		{
			bool thereIsPen = Exist("PEN", buget);
			bool thereIsPencil = Exist("PENCIL", buget);

			if (thereIsPen && thereIsPencil)
			{
				return buget.Value * 0.05;
			}

			return Next.ApplyRule(buget);
		}

		private bool Exist(String itemName, Buget buget)
		{
			foreach (Item item in buget.Itens)
			{
				if (item.Name.ToUpper().Equals(itemName))
					return true;
			}
			return false;
		}
	}
}
