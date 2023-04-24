using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exercise
{
	public class BankAccount
	{
		public double Balance { get; set; }
        public string AccountHolder { get; set; }

		public BankAccount() { }

		public BankAccount(double balance, string accountHolder)
		{
			this.Balance = balance;
			this.AccountHolder = accountHolder;
		}
    }
}
