using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    public class SavingsAccount : Account
    {
        public SavingsAccount()
        {
            AccountType = AccountType.Savings;
            balance = 0.00M;
        }

        public SavingsAccount(Decimal balance)
        {
            AccountType = AccountType.Savings;
            this.balance = balance;
        }

        public override decimal Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override decimal Transfer(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override decimal Withdrawal(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
