using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        private decimal amount;
        public decimal Amount 
        {
            get
            {
                return amount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be positive");
                }

                this.amount = value;
            }
    
        }

        public Account(decimal initialAmount)
        {
            this.Amount = initialAmount;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Value must be positive");
            }

            this.Amount += amount;
        }
    }
}
