using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGyak
{
	internal class BankCard : BankingService
	{

		double accountBalance;
		string cardNumber;

		public string CardNumber { get; }

		public double AccountBalance { get; }

		public BankCard(Owner owner, double accountBalance, string cardNumber) : base(owner)
		{
			this.accountBalance = accountBalance;
			this.cardNumber = cardNumber;
		}


		public bool Purchase(double amount)
		{
			if (this.accountBalance - amount >= 0)
			{
				this.accountBalance -= amount;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
	
	
}
