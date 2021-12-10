using System;

namespace Bank
{
    public class BankAccount
    {
        public decimal Amount { get; private set; }

        public BankAccount(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Value must be positive");
            }

            this.Amount = amount;
        }

    }
}