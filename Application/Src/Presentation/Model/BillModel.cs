
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

        public string ConfirmationNumber { get; set; }
        public DateTime DateOwed { get; set; }
        public decimal MonthlyPayment { get; set; }
        public int ParentId { get; set; }
        public bool Paid { get; set; }
        public int RecordId { get; set; }

        #endregion

        #region Public Methods

        public void CopyFrom(IBill bill)
        {
            ConfirmationNumber = bill.ConfirmationNumber;
            DateOwed = bill.DateOwed;
            MonthlyPayment = bill.MonthlyPayment;
            Paid = bill.Paid;
            RecordId = bill.RecordId;
        }

        #endregion

    }
}
