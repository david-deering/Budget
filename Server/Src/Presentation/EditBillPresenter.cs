
using Domain;

namespace Presentation
{
    public class EditBillPresenter : AbstractPresenter
    {

        #region Constructors

        public EditBillPresenter()
        {
            Service = Factory.CreateBillService(string.Empty, string.Empty);
        }

        #endregion

        #region Properties

        private IBillService Service { get; set; }

        #endregion

        #region Public Methods

        public void EditBill(BillModel model)
        {
            IBill bill = Service.GetBill(model.RecordId);
            bill.DateOwed = model.DateOwed;
            bill.MonthlyPayment = model.MonthlyPayment;
            bill.Name = model.Name;
            bill.TotalOwed = model.TotalOwed;
            Service.UpdateBill(bill);
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
