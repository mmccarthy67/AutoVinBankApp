namespace BankApplication
{
    public abstract class Account
    {
        public decimal balance;
        public AccountType AccountType;
        public InvestmentAccountType InvestmentAccountType;
        public abstract decimal Deposit(decimal amount);
        public abstract decimal Withdrawal(decimal amount);
        public abstract decimal Transfer(decimal amount);
    }
}