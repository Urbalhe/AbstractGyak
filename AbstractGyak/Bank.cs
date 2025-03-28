using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGyak
{
	internal class Bank
	{
		BankAccount[] accounts;


		public Bank(int maxAccountCount)
		{
			accounts = new BankAccount[maxAccountCount];
		}


		public BankAccount NewAccount(Owner owner, double creditLimit)
		{
			if (creditLimit == 0)
			{
				return new SavingsAccount(owner);
			}
			else 
			{
				return new CreditAccount(owner, creditLimit);
			}
		}

		public double TotalBalance(Owner owner)
		{
			double osszeg = 0;
			foreach (var account in accounts)
			{
				osszeg += account.Balance;
			}

			return osszeg;
		}

		public BankAccount MaximalBalanceAccount(Owner owner) 
		{
			BankAccount maxBancAccount = accounts[0];

            for (int i = 0; i < accounts.Length; i++)
            {
				if (accounts[i].Balance > maxBancAccount.Balance) maxBancAccount;
            }

			return maxBancAccount;
        }


		public double TotalCreditLimit()
		{
			double osszeg = 0;

            foreach (var item in accounts)
            {
				if (accounts is CreditAccount)
				{
					osszeg += (account as CreditAccount).CreditLimit;
				}
                
            }

			return osszeg;
        }
	
	
	}
}
