using System.Collections.Generic;

namespace BankAccounts
{
    internal abstract class TheBank
    {
        protected List<Account> AccountsList;
        internal TheBank(string name)
        {
            this.AccountsList = new List<Account>();
            this.Name = name;
        }

        public string Name { get; }
    }
}