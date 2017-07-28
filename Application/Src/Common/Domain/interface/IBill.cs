using System;

namespace Domain
{
    public interface IBill
    {
        string ConfirmationNumber { get; set; }
        DateTime DateOwed { get; set; }
        decimal MonthlyPayment { get; set; }
        bool Paid { get; set; }
        int RecordId { get; set; }
    }
}
