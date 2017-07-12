namespace Domain
{
    public class NullBillService : IBillService
    {

        public static IBillService Singleton = new NullBillService();

        #region Constructors

        protected NullBillService()
        {
        }

        #endregion

        #region Public Methods

        public virtual void AddBill(IBill sprint)
        {
            // do nothing
        }

        public virtual void DeleteBill(int recordId)
        {
            // do nothing
        }

        public virtual IBill GetBill(int recordId)
        {
            return null;
        }

        public virtual IBill[] GetBills()
        {
            return new IBill[0];
        }

        public virtual void UpdateBill(IBill sprint)
        {
            //  do nothing
        }

        #endregion

    }
}
