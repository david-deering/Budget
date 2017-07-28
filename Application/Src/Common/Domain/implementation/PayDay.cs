using System;

namespace Domain
{
    public class PayDay : IPayDay
    {
        public virtual DateTime Date { get; set; }
        public virtual decimal Amount { get; set; }

        public virtual int RecordId { get; set; }
    }
}
