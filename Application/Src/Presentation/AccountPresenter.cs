using Domain;
using System.Linq;

namespace Presentation
{
    public class AccountPresenter : AbstractPresenter
    {

        #region Constructors

        public AccountPresenter()
        {
            Service = Factory.CreateAccountService();
        }

        #endregion

        #region Properties

        private IAccountService Service { get; set; }

        #endregion

        #region Public Methods

        public AccountModel[] GetAccounts()
        {
            IAccount[] accounts = Service.GetAccounts();
            return accounts.Select(GetAccount).ToArray();
        }

        #endregion

        #region Helper Methods

        private AccountModel GetAccount(IAccount account)
        {
            AccountModel model = new AccountModel();
            model.CopyFrom(account);
            return model;
        }

        #endregion

    }
}
