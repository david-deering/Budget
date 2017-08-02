using System;

namespace Domain
{
    public class DateDecimal
    {

        #region Constructors

        public DateDecimal(DateTime date, decimal number)
        {
            Date = date;
            Amount = number;
        }

        #endregion

        #region Properties

        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        #endregion

        #region Public Methods



        #endregion

        #region Helper Methods



        #endregion

    }
}
