

using System;

namespace Domain
{
    public interface IAccount
    {
        string CompanyName { get; set; }
        decimal AccountBalance { get; set; }
        decimal InterestRate { get; set; }
        int RecordId { get; set; }

        void AddBill(IBill bill);
        void GeneratePaymentSchedule(DateTime firstDueDate, decimal monthlyPayment);
        IBill[] GetBills();
    }
}
