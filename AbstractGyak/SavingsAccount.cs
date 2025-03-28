using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGyak
{
	internal class SavingsAccount : BankAccount
	{
		static double baseInterest;


		public double Interest { get; set; }

		public SavingsAccount(Owner owner) : base(owner)
		{
			Interest = baseInterest;
		}



		public override bool Withdraw(double amount)
		{
			if (Balance - amount >= 0)
			{
				Balance -= amount;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void AddInterest()
		{
			Balance += Balance * (Interest / 100);
		}

	}
}
