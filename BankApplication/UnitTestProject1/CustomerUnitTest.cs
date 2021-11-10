using BankApplication;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApplicationUnitTest
{
    [TestClass]
    public class CustomerUnitTest
    {
        private static readonly string FIRST_NAME = "Michael";
        private static readonly string LAST_NAME = "McCarthy";
        Customer customer;

        [TestInitialize]
        public void Init()
        {
            customer = new Customer(FIRST_NAME, LAST_NAME);
        }

        [TestMethod]
        public void TestCreatingCustomer()
        {
            Assert.AreEqual(FIRST_NAME, customer.FirstName);
            Assert.AreEqual(LAST_NAME, customer.LastName);
        }

        [TestMethod]
        public void TestAddingCheckingAccountToCustomer()
        {
            Account checkingAccount = new CheckingAccount();
            Assert.IsTrue(checkingAccount.AccountType == AccountType.Checking);
            Assert.AreEqual(0.00M, checkingAccount.balance);

            customer.Accounts.Add(AccountType.Checking, checkingAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Checking));
            Assert.IsTrue(customer.Accounts.ContainsValue(checkingAccount));
        }

        [TestMethod]
        public void TestAddingCheckingAccountToCustomerWithBalance()
        {
            Account checkingAccount = new CheckingAccount(100.00M);
            Assert.IsTrue(checkingAccount.AccountType == AccountType.Checking);
            Assert.AreEqual(100.00M, checkingAccount.balance);

            customer.Accounts.Add(AccountType.Checking, checkingAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Checking));
            Assert.IsTrue(customer.Accounts.ContainsValue(checkingAccount));
        }

        [TestMethod]
        public void TestAddingSavingsAccountToCustomer()
        {
            Account savingsAccount = new SavingsAccount();
            Assert.IsTrue(savingsAccount.AccountType == AccountType.Savings);
            Assert.AreEqual(0.00M, savingsAccount.balance);

            customer.Accounts.Add(AccountType.Savings, savingsAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Savings));
            Assert.IsTrue(customer.Accounts.ContainsValue(savingsAccount));
        }

        [TestMethod]
        public void TestAddingSavingsAccountToCustomerWithBalance()
        {
            Account savingsAccount = new SavingsAccount(100.00M);
            Assert.IsTrue(savingsAccount.AccountType == AccountType.Savings);
            Assert.AreEqual(100.00M, savingsAccount.balance);

            customer.Accounts.Add(AccountType.Savings, savingsAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Savings));
            Assert.IsTrue(customer.Accounts.ContainsValue(savingsAccount));
        }

        [TestMethod]
        public void TestAddingIndividualInvestmentAccountToCustomer()
        {
            Account investmentAccount =
                new InvestmentAccount(InvestmentAccountType.Individual);
            Assert.IsTrue(investmentAccount.AccountType == AccountType.Investment);
            Assert.IsTrue(investmentAccount.InvestmentAccountType ==
                InvestmentAccountType.Individual);
            Assert.AreEqual(0.00M, investmentAccount.balance);

            customer.Accounts.Add(AccountType.Investment, investmentAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Investment));
            Assert.IsTrue(customer.Accounts.ContainsValue(investmentAccount));
        }

        [TestMethod]
        public void TestAddingIndividualInvestmentAccountToCustomerWithBalance()
        {
            Account investmentAccount =
                new InvestmentAccount(InvestmentAccountType.Individual, 100.00M);
            Assert.IsTrue(investmentAccount.AccountType == AccountType.Investment);
            Assert.IsTrue(investmentAccount.InvestmentAccountType ==
                InvestmentAccountType.Individual);
            Assert.AreEqual(100.00M, investmentAccount.balance);

            customer.Accounts.Add(AccountType.Investment, investmentAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Investment));
            Assert.IsTrue(customer.Accounts.ContainsValue(investmentAccount));
        }

        [TestMethod]
        public void TestAddingCorporateInvestmentAccountToCustomer()
        {
            Account investmentAccount =
                new InvestmentAccount(InvestmentAccountType.Corporate);
            Assert.IsTrue(investmentAccount.AccountType == AccountType.Investment);
            Assert.IsTrue(investmentAccount.InvestmentAccountType ==
                InvestmentAccountType.Corporate);
            Assert.AreEqual(0.00M, investmentAccount.balance);

            customer.Accounts.Add(AccountType.Investment, investmentAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Investment));
            Assert.IsTrue(customer.Accounts.ContainsValue(investmentAccount));
        }

        [TestMethod]
        public void TestAddingCorporateInvestmentAccountToCustomerWithBalance()
        {
            Account investmentAccount =
                new InvestmentAccount(InvestmentAccountType.Corporate, 100.00M);
            Assert.IsTrue(investmentAccount.AccountType == AccountType.Investment);
            Assert.IsTrue(investmentAccount.InvestmentAccountType ==
                InvestmentAccountType.Corporate);
            Assert.AreEqual(100.00M, investmentAccount.balance);

            customer.Accounts.Add(AccountType.Investment, investmentAccount);
            Assert.IsNotNull(customer.Accounts);
            Assert.IsTrue(customer.Accounts.ContainsKey(AccountType.Investment));
            Assert.IsTrue(customer.Accounts.ContainsValue(investmentAccount));
        }
    }
}
