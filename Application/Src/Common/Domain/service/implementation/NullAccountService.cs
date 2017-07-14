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

        public virtual void UpdateAccount(IAccount account)
        {
            //  do nothing
        }

        #endregion

    }
}
