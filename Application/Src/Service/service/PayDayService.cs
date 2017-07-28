using Domain;

namespace Service
{
    public class PayDayService : AbstractService, IPayDayService
    {

        #region Constructors

        public PayDayService(IDatabaseConnection databaseConnection)
            : base(databaseConnection)
        {

        }

        #endregion

        #region Properties

        #endregion

        #region Public Methods

        public void AddPayDay(IPayDay payDay)
        {
            // guard clause - invalid input
            if (payDay == null)
            {
                return;
            }

            Save(payDay);
        }

        public void DeletePayDay(int recordId)
        {
            // guard clause - not found
            IPayDay foundPayDay = Get<IPayDay>(recordId);
            if (foundPayDay == null)
            {
                return;
            }

            Delete(foundPayDay);
        }

        public IPayDay GetPayDay(int recordId)
        {
            // guard clause - not found
            IPayDay payDayTobuild = Get<IPayDay>(recordId);
            return payDayTobuild;
        }

        public IPayDay[] GetPayDays()
        {
            IPayDay[] payDaysToBuild = Get<IPayDay>();

            return payDaysToBuild;
        }


        public void UpdatePayDay(IPayDay payDay)
        {
            // guard clause - invalid input
            if (payDay == null)
            {
                return;
            }

            Update(payDay);
        }

        #endregion

    }
}
