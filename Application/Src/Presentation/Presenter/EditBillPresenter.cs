
using Domain;

namespace Presentation
{
    public class EditBillPresenter : AbstractPresenter
    {

        #region Constructors

        public EditBillPresenter()
        {
            Service = Factory.CreateAccountService();
        }

        #endregion

        #region Properties

        private IAccountService Service { get; set; }

        #endregion

        #region Public Methods

        public void EditBill(BillModel model)
        {
            IBill bill = Service.GetBill(model.RecordId);
            bill.DateOwed = model.DateOwed;
            bill.MonthlyPayment = model.MonthlyPayment;
            bill.Paid = model.Paid;
            Service.UpdateBill(bill);
        }

        #endregion

        #region Helper Methods

        #endregion

    }
}
