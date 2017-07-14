using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Test.Mock
{
    public class MockAccountService : IAccountService
    {

        public MockAccountService()
        {
            RecordIdGenerator = 1;
            accounts = new List<IAccount>();
        }

        public List<IAccount> accounts { get; set; }
        private int RecordIdGenerator { get; set; }

        public void AddAccount(IAccount account)
        {
            account.RecordId = RecordIdGenerator;
            RecordIdGenerator++;
            accounts.Add(account);
        }

        public void DeleteAccount(int recordId)
        {
            IAccount account = accounts.FirstOrDefault(b => b.RecordId == recordId);
            accounts.Remove(account);
        }

        public IAccount GetAccount(int recordId)
        {
            return accounts.FirstOrDefault(b => b.RecordId == recordId);
        }
        public IAccount[] GetAccounts()
        {
            return accounts.ToArray();
        }

        public void UpdateAccount(IAccount account)
        {
            DeleteAccount(account.RecordId);
            accounts.Add(account);
        }
    }
}