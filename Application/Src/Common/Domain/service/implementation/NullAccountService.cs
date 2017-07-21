namespace Domain
{
    public class NullAccountService : IAccountService
    {

        public static IAccountService Singleton = new NullAccountService();

        #region Constructors

        protected NullAccountService()
        {
        }

        #endregion

        #region Public Methods

        public virtual void AddAccount(IAccount sprint)
        {
            // do nothing
        }

        public virtual void AddBill(IBill bill, IAccount account)
        {
            //do nothing
        }

        public virtual void DeleteAccount(int recordId)
        {
            // do nothing
        }

        public virtual IAccount GetAccount(int recordId)
        {
            return null;
        }

        public virtual IAccount[] GetAccounts()
        {
            return new IAccount[0];
        }

        public IBill GetBill(int recordId)
        {
            return null;
        }

        public IBill[] GetBills(int accountRecordId)
        {
            return new IBill[0];
        }

        public virtual void UpdateAccount(IAccount account)
        {
            //  do nothing
        }

        public void UpdateBill(IBill bill)
        {
            // do nothing
        }

        #endregion

    }
}
