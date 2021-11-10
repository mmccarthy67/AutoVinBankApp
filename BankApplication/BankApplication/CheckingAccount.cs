using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    public class CheckingAccount : Account
    {
        public CheckingAccount()
        {
            AccountType = AccountType.Checking;
            balance = 0.00M;
        }

        public CheckingAccount(Decimal balance)
        {
            AccountType = AccountType.Checking;
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
