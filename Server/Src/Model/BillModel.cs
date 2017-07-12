using Domain;

namespace Model
{
    public class BillModel : AbstractModel
    {

        #region Constructors

        public BillModel()
        {
        }

        #endregion

        #region Properties

        public string DateOwed { get; set; }
        public string Name { get; set; }
        public decimal TotalOwed { get; set; }

        #endregion

        #region Public Methods

        public void CopyFrom(Bill bill)
        {
            DateOwed = FromDate(bill.DateOwed);
            Name = bill.Name;
            TotalOwed = bill.TotalOwed;
        }

        #endregion

    }
}
