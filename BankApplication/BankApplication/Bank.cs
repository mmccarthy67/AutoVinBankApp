using System.Collections.Generic;

namespace BankApplication
{
    public class Bank
    {
        public Bank(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public List<Customer> Customers { get; set; }
    }
}
