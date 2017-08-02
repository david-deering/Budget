using System;

namespace Service
{
    public interface IPayPeriodBuilder
    {
        //attributes
        DateTime StartDate { get; set; }
        decimal Surplus { get; set; }
        decimal Deficit { get; set; }

        //behavior
        void Build();

    }
}
