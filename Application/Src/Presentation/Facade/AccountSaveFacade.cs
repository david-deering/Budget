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

        public bool Validate(AccountModel model)
        {
            IAccount account = Service.GetAccounts().FirstOrDefault(a => a.CompanyName == model.CompanyName);

            //guard clause - no result
            if (account == null)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
