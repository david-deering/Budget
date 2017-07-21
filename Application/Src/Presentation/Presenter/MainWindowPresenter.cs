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
            BillService = Factory.CreateBillService(string.Empty, string.Empty);
            AccountService = Factory.CreateAccountService();
        }

        #endregion

        #region Properties

        private IBillService BillService { get; set; }
        private IAccountService AccountService { get; set; }

        #endregion

        #region Private Members

        private const string Header1 = "Company Name";
        private const string Header2 = "Monthly Payment";
        private const string Header3 = "Date Due";
        private const string Header4 = "Account Balance";

        #endregion

        #region Public Methods

        public void DeleteAccount(AccountModel model)
        {
            AccountService.DeleteAccount(model.RecordId);
        }

        public void MakeDatabaseEntries()
        {
            IAccount account = new Account();
            account.CompanyName = "Haribo";
            account.AccountBalance = 200.00m;
            account.InterestRate = 3.9m;
            account.GeneratePaymentSchedule(DateTime.Now, 20.00m);
            AccountService.AddAccount(account);
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

        private AccountModel GetAccount(IAccount account)
        {
            AccountModel model = new AccountModel();
            model.CopyFrom(account);
            return model;
        }

        #endregion

    }
}
