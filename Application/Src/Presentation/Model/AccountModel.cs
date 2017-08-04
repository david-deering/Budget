using Domain;
using System.Linq;

namespace Presentation
{
    public class AccountModel : AbstractModel
    {

        #region Constructors

        public AccountModel()
        {
        }

        #endregion

        #region Properties

        public string CompanyName { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal InterestRate { get; set; }
        public bool IsActive { get; set; }
        public int RecordId { get; set; }
        public BillModel[] Bills { get; set; }

        #endregion

        #region Public Methods

        public void CopyFrom(IAccount account)
        {
            CompanyName = account.CompanyName;
            AccountBalance = account.AccountBalance;
            InterestRate = account.InterestRate;
            IsActive = account.IsActive;
            RecordId = account.RecordId;

            Bills = account.GetBills().Select(GetBill).ToArray();
        }

        #endregion

        #region Helper Methods

        private BillModel GetBill(IBill bill)
        {
            BillModel model = new BillModel();
            model.CopyFrom(bill);
            return model;
        }

        #endregion

    }
}
