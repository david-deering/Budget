using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Test.Mock
{
    public class MockAccountService : IAccountService
    {
        public static MockAccountService Singleton = new MockAccountService();

        public MockAccountService()
        {
            AccountRecordIdGenerator = 1;
            Accounts = new List<IAccount>();
            BillRecordIdGenerator = 1;
            Bills = new List<IBill>();
        }

        private List<IAccount> Accounts { get; set; }
        private int AccountRecordIdGenerator { get; set; }
        private List<IBill> Bills { get; set; }
        private int BillRecordIdGenerator { get; set; }

        public void AddAccount(IAccount account)
        {
            List<IBill> bills = account.GetBills().ToList();
            account.RecordId = AccountRecordIdGenerator;
            AccountRecordIdGenerator++;
            Accounts.Add(account);
            bills.ForEach(AssignRecordIdToBill);
            bills.ForEach(Bills.Add);
        }

        public void AddBill(IBill bill, IAccount account)
        {
            AssignRecordIdToBill(bill);
            account.AddBill(bill);
            Bills.Add(bill);
        }

        public void ClearMockService()
        {
            AccountRecordIdGenerator = 1;
            Accounts.Clear();
            BillRecordIdGenerator = 1;
            Bills.Clear();
        }

        public void DeleteAccount(int recordId)
        {
            IAccount account = Accounts.FirstOrDefault(b => b.RecordId == recordId);
            Accounts.Remove(account);
        }

        public IAccount GetAccount(int recordId)
        {
            return Accounts.FirstOrDefault(b => b.RecordId == recordId);
        }
        public IAccount[] GetAccounts()
        {
            return Accounts.ToArray();
        }


        public IBill GetBill(int recordId)
        {
            return Bills.FirstOrDefault(b => b.RecordId == recordId);
        }

        public IBill[] GetBills(int accountRecordId)
        {
            IAccount account = Accounts.FirstOrDefault(a => a.RecordId == accountRecordId);

            if (account == null)
            {
                return null;
            }

            return account.GetBills();
        }

        public void UpdateAccount(IAccount account)
        {
            DeleteAccount(account.RecordId);
            Accounts.Add(account);
        }

        public void UpdateBill(IBill bill)
        {
            IBill savedBill = GetBill(bill.RecordId);
            savedBill.DateOwed = bill.DateOwed;
            savedBill.MonthlyPayment = bill.MonthlyPayment;
        }

        #region HelperMethods

        public void AssignRecordIdToBill(IBill bill)
        {
            bill.RecordId = BillRecordIdGenerator;
            BillRecordIdGenerator++;
        }

        #endregion
    }
}