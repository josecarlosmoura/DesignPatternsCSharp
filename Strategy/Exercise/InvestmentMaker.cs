using Strategy.Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Exercise
{
	public class InvestmentMaker
	{
		public double Invest(IInvest invest, double investValue)
		{
			double valeu = invest.MakeInvestment(investValue);

			return valeu * 0.75;
		}
	}
}
