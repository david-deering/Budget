using System;

namespace Domain
{
    public interface IPayDay
    {
        DateTime Date { get; set; }
        decimal Amount { get; set; }

        int RecordId { get; set; }
    }
}
