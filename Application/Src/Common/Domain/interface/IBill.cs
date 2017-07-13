using System;

namespace Domain
{
    public interface IBill
    {
        DateTime DateOwed { get; set; }

        string Name { get; set; }

        decimal MonthlyPayment { get; set; }
        decimal TotalOwed { get; set; }

        int RecordId { get; set; }
    }
}
