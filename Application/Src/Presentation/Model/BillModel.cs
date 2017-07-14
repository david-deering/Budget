
using Domain;
using System;

namespace Presentation
{
    public class BillModel : AbstractModel
    {

        #region Constructors

        public BillModel()
        {
        }

        #endregion

        #region Properties

        public DateTime DateOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        public int RecordId { get; set; }

        #endregion

        #region Public Methods

        public void CopyFrom(IBill bill)
        {
            DateOwed = bill.DateOwed;
            MonthlyPayment = bill.MonthlyPayment;
            RecordId = bill.RecordId;
        }

        #endregion

    }
}
