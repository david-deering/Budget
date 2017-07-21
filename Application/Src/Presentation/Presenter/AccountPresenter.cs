using Domain;
using System;
using System.Linq;

namespace Presentation
{
    public class AccountPresenter : AbstractPresenter
    {

        #region Constructors

        public AccountPresenter()
        {
            Service = Factory.CreateAccountService();
            SaveFacade = new AccountSaveFacade();
        }

        #endregion

        #region Properties

        private IAccountService Service { get; set; }
        private AccountSaveFacade SaveFacade { get; set; }

        #endregion

        #region Public Methods

        public AccountModel[] GetAccounts()
        {
            IAccount[] accounts = Service.GetAccounts();
            return accounts.Select(GetAccount).ToArray();
        }

        public void EditAccount(AccountModel model)
        {
            bool isValid = SaveFacade.Validate(model);

            if (!isValid)
            {
                throw new ArgumentException("An account with that name already esists");
            }

            IAccount account = Service.GetAccount(model.RecordId);
            SaveFacade.Apply(model, account);
            Service.UpdateAccount(account);
        }

        public void SaveAccount(AddAccountModel model)
        {
            bool isValid = SaveFacade.Validate(model);

            if (!isValid)
            {
                throw new ArgumentException("An account with that name already esists");
            }

            IAccount account = SaveFacade.Apply(model);
            Service.AddAccount(account);
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
