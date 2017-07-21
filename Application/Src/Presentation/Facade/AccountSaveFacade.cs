using Domain;
using System.Linq;

namespace Presentation
{
    public class AccountSaveFacade
    {

        #region Constructors

        public AccountSaveFacade()
        {
            Factory = ServiceFactoryProxy.Singleton.ServiceFactory;
            Service = Factory.CreateAccountService();
        }

        #endregion

        #region Properties

        private IServiceFactory Factory { get; set; }
        private IAccountService Service { get; set; }

        #endregion

        #region Public Methods

        public IAccount Apply(AddAccountModel model)
        {
            IAccount account = new Account();
            account.AccountBalance = model.AccountBalance;
            account.CompanyName = model.CompanyName;
            account.InterestRate = model.InterestRate;
            account.RecordId = 0;

            account.GeneratePaymentSchedule(model.FirstDueDate, model.AmountDue);
            return account;
        }

        public void Apply(AccountModel model, IAccount account)
        {
            account.AccountBalance = model.AccountBalance;
            account.CompanyName = model.CompanyName;
            account.InterestRate = model.InterestRate;
        }

        public bool Validate(AddAccountModel model)
        {
            return IsDuplicateName(model.CompanyName);
        }

        public bool Validate(AccountModel model)
        {

            return IsDuplicateName(model.CompanyName, model.RecordId);
        }

        #endregion

        #region Helper Methods

        private bool IsDuplicateName(string name)
        {
            return IsDuplicateName(name, 0);
        }

        private bool IsDuplicateName(string name, int recordId)
        {
            IAccount account = Service.GetAccounts().FirstOrDefault(a => a.CompanyName == name);

            //guard clause - no result
            if (account == null)
            {
                return true;
            }

            //guard clause - Editing existing account
            if (account.RecordId == recordId)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
