using Domain;
using Service;
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


        public void AddPayDay(PayDayModel model)
        {
            PayDaySaveFacade facade = new PayDaySaveFacade();
            IPayDay payDay = facade.Apply(model);
            PayDayService.AddPayDay(payDay);
        }


        public void GenerateBillsIfNewMonth()
        {
            IBill[] bills = AccountService.GetBills().Where(b => b.DateOwed.Month == DateTime.Today.Month).ToArray();

            if (bills.Length != 0)
            {
                return;
            }

            AccountService.GetAccounts().Where(a => a.IsActive).ToList().ForEach(GenerateNewBill);

        }

        public void DeleteAccount(int recordId)
        {
            AccountService.DeleteAccount(recordId);
        }

        public void DeleteIncome(int recordId)
        {
            PayDayService.DeletePayDay(recordId);
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

        public string[] GetHeaderValues()
        {
            List<string> values = new List<string>();
            values.Add(Header1);
            values.Add(Header2);
            values.Add(Header3);
            values.Add(Header4);
            return values.ToArray();
        }
        public PayDayModel[] GetPayDaysInMonth(DateTime date)
        {
            return PayDayService.GetPayDays().Where(pd => pd.Date.Month == date.Month && pd.Date.Year == date.Year).Select(CreateModel).ToArray();
        }

        public DateDecimal[] GetBudget()
        {
            BudgetDirector director = new BudgetDirector();
            return director.Construct();
        }

        public void UpdateAccount(AccountModel model)
        {
            IAccount account = AccountService.GetAccount(model.RecordId);
            AccountSaveFacade facade = new AccountSaveFacade();
            facade.Apply(model, account);
            AccountService.UpdateAccount(account);
        }

        #endregion

        #region Helper Methods

        private PayDayModel CreateModel(IPayDay payday)
        {
            PayDayModel model = new PayDayModel();
            model.CopyFrom(payday);
            return model;
        }

        private void GenerateNewBill(IAccount account)
        {
            List<IBill> bills = account.GetBills().ToList();
            int lastIndex = bills.Count;
            IBill lastBill = bills[lastIndex - 1];
            IBill newBill = new Bill();
            newBill.RecordId = 0;
            newBill.DateOwed = lastBill.DateOwed.AddMonths(1);
            newBill.MonthlyPayment = lastBill.MonthlyPayment;
            newBill.Paid = false;
            newBill.ConfirmationNumber = "";
            account.AddBill(newBill);
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
