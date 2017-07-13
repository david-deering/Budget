using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Test.Mock
{
    public class MockBillService : IBillService
    {

        public MockBillService()
        {
            RecordIdGenerator = 1;
            bills = new List<IBill>();
        }

        public List<IBill> bills { get; set; }
        private int RecordIdGenerator { get; set; }


        public void AddBill(IBill bill)
        {
            bill.RecordId = RecordIdGenerator;
            RecordIdGenerator++;
            bills.Add(bill);
        }

        public void DeleteBill(int recordId)
        {
            IBill bill = bills.FirstOrDefault(b => b.RecordId == recordId);
            bills.Remove(bill);
        }

        public IBill GetBill(int recordId)
        {
            return bills.FirstOrDefault(b => b.RecordId == recordId);
        }
        public IBill[] GetBills()
        {
            return bills.ToArray();
        }

        public void UpdateBill(IBill bill)
        {
            DeleteBill(bill.RecordId);
            bills.Add(bill);
        }
    }
}
