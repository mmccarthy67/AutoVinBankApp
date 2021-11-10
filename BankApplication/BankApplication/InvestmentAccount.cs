using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication
{
    public class InvestmentAccount : Account
    {
        private static readonly double INDIVIDUAL_WITHDRAWAL_AMOUNT = 500.00;

        public InvestmentAccount(InvestmentAccountType investmentAccountType)
        {
            AccountType = AccountType.Investment;
            balance = 0.00M;
            InvestmentAccountType = investmentAccountType;
        }

        public InvestmentAccount(InvestmentAccountType investmentAccountType, Decimal balance)
        {
            AccountType = AccountType.Investment;
            this.balance = balance;
            InvestmentAccountType = investmentAccountType;
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
