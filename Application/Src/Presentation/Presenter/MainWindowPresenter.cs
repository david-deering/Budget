using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentation
{
    public class MainWindowPresenter : AbstractPresenter
    {

        #region Constructors

        public MainWindowPresenter()
        {
            AccountService = Factory.CreateAccountService();
            PayDayService = Factory.CreatePayDayService();
        }

        #endregion

        #region Properties

        private IAccountService AccountService { get; set; }
        private IPayDayService PayDayService { get; set; }

        #endregion

        #region Private Members

        private const string Header1 = "Company Name";
        private const string Header2 = "Monthly Payment";
        private const string Header3 = "Date Due";
        private const string Header4 = "Account Balance";

        #endregion

        #region Public Methods

        public PayDayModel[] GetPayDaysInMonth(DateTime date)
        {
            return PayDayService.GetPayDays().Where(pd => pd.Date.Month == date.Month && pd.Date.Year == date.Year).Select(CreateModel).ToArray();
        }

        public void DeleteAccount(AccountModel model)
        {
            AccountService.DeleteAccount(model.RecordId);
        }

        public string[] GetHeaderValues()
        {
            List<string> values = new List<string>();
            values.Add(Header1);
            values.Add(Header2);
            values.Add(Header3);
            values.Add(Header4);
            return values.ToArray();
        }

        public AccountModel[] GetAccounts()
        {
            IAccount[] accounts = AccountService.GetAccounts();

            // guard clause - empty
            if (accounts.Length == 0)
            {
                return new AccountModel[0];
            }

            return accounts.Select(GetAccount).ToArray();
        }

        #endregion

        #region Helper Methods

        private PayDayModel CreateModel(IPayDay payday)
        {
            PayDayModel model = new PayDayModel();
            model.CopyFrom(payday);
            return model;
        }

        private AccountModel GetAccount(IAccount account)
        {
            AccountModel model = new AccountModel();
            model.CopyFrom(account);
            return model;
        }

        #endregion

    }
}
