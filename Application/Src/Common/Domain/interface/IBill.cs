using System;

namespace Domain
{
    public interface IBill
    {
        DateTime DateOwed { get; set; }
        decimal MonthlyPayment { get; set; }
        int RecordId { get; set; }
    }
}
