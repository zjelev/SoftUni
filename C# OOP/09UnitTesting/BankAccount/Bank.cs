using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Bank
    {
        private IAccountManager accountManager;

        // Explicit dependency:
        public Bank(IAccountManager accountManager)
        {
            this.accountManager = accountManager; // injecting dependencies
        }
    }
}
