using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGyak
{

	internal abstract class BankAccount : BankingService
	{
		double balance;

		public virtual  double Balance { get; protected set;}

		protected BankAccount(double balance, Owner owner) : base(owner)
		{
			this.balance = balance;
		}


		public void Deposit(double amount)
		{
			balance += amount;
		}

		public abstract bool Withdraw(double amount);
		

	}
}
		
			

			
		
	

