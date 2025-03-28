using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGyak
{
	internal class CreditAccount : BankAccount
	{

		double creditLimit;

		public CreditAccount(double balance, Owner owner) : base(balance, owner)
		{

		}

		public double CreditLimit { get; }
		

		public override bool Withdraw(double amount)
		{
			if (this.Balance - amount >= creditLimit)
			{
				this.Balance -= amount;
				return true;
			}
			else
			{
				return false;
			}

			
			
		}


		
			
		
		
	}
}
