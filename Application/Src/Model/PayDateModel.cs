using Domain;

namespace Model
{
    public class PayDateModel : AbstractModel
    {
        #region Properties

        public string Date { get; set; }
        public decimal AmountPaid { get; set; }

        #endregion

        #region Public Methods

        public void CopyFrom(IPayDate payDate)
        {
            Date = FromDate(payDate.Date);
            AmountPaid = payDate.AmountPaid;
        }

        #endregion
    }
}
