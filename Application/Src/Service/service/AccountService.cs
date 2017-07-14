using Domain;

namespace Service
{
    public class AccountService : AbstractService, IAccountService
    {

        #region Constructors

        public AccountService(IDatabaseConnection databaseConnection)
            : base(databaseConnection)
        {

        }

        #endregion

        #region Properties

        #endregion

        #region Public Methods

        public void AddAccount(IAccount account)
        {
            // guard clause - invalid input
            if (account == null)
            {
                return;
            }

            Save(account);
        }

        public void DeleteAccount(int recordId)
        {
            // guard clause - not found
            IAccount foundAccount = Get<IAccount>(recordId);
            if (foundAccount == null)
            {
                return;
            }

            Delete(foundAccount);
        }

        public IAccount GetAccount(int recordId)
        {
            // guard clause - not found
            IAccount accountTobuild = Get<IAccount>(recordId);

            if (accountTobuild == null)
            {
                return null;
            }

            return accountTobuild;
        }

        public IAccount[] GetAccounts()
        {
            IAccount[] accountsToBuild = Get<IAccount>();

            return accountsToBuild;
        }

        public void UpdateAccount(IAccount account)
        {
            // guard clause - invalid input
            if (account == null)
            {
                return;
            }

            Update(account);
        }

        #endregion
    }
}
