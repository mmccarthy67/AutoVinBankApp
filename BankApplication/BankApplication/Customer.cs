using System.Collections.Generic;

namespace BankApplication
{
    public class Customer
    {
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Dictionary<AccountType, Account> Accounts = new Dictionary<AccountType, Account>();
    }
}
