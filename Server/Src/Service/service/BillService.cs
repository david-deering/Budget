
using Domain;

namespace Service
{
    public class BillService : AbstractService, IBillService
    {

        #region Constructors

        public BillService(IDatabaseConnection databaseConnection)
            : base(databaseConnection)
        {
        }

        #endregion

        #region Public Methods

        public void AddBill(IBill bill)
        {
            // guard clause - invalid input
            if (bill == null)
            {
                return;
            }

            Save(bill);
        }

        public void DeleteBill(int recordId)
        {
            // guard clause - not found
            IBill foundBill = Get<IBill>(recordId);
            if (foundBill == null)
            {
                return;
            }

            Delete(foundBill);
        }

        public IBill GetBill(int recordId)
        {
            // guard clause - not found
            IBill billTobuild = Get<IBill>(recordId);

            if (billTobuild == null)
            {
                return null;
            }

            return billTobuild;
        }

        public IBill[] GetBills()
        {
            IBill[] billsToBuild = Get<IBill>();

            return billsToBuild;
        }

        public void UpdateBill(IBill bill)
        {
            // guard clause - invalid input
            if (bill == null)
            {
                return;
            }

            Update(bill);
        }

        #endregion

    }
}
