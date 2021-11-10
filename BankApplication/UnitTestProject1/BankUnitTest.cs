using BankApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BankApplicationUnitTest
{
    [TestClass]
    public class BankUnitTest
    {
        private const string BANK_NAME = "AutoVin Bank";
        Bank bank;

        [TestInitialize]
        public void Init()
        {
            bank = new Bank(BANK_NAME);
        }

        [TestMethod]
        public void TestCreateBankWithName()
        {
            Assert.IsNotNull(bank);
            Assert.AreEqual(BANK_NAME, bank.Name);
        }

        [TestMethod]
        public void TestAddingCustomerToBank()
        {
            string firstName = "Michael";
            string lastName = "McCarthy";

            Customer customer = 
                new Customer(firstName, lastName);
            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);

            bank.Customers = new List<Customer>
            {
                customer
            };
            
            Assert.IsNotNull(bank.Customers);
            Assert.IsTrue(bank.Customers.Contains(customer));
        }
    }
}
