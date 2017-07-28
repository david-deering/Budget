using Domain;
using System;
using Test.Mock;

namespace Test.PresentationTests
{
    public abstract class AbstractTest
    {

        #region Constructors

        protected AbstractTest()
        {
            ServiceFactoryProxy.Singleton.SetServiceFactory(new MockServiceFactory());
            ServiceFactory = ServiceFactoryProxy.Singleton.ServiceFactory;
        }

        #endregion

        #region Constants

        public const decimal AccountBalance = 100.99m;
        public const string CompanyName = "Test";
        public const decimal AmountDue = 2m;
        public const decimal InterestRate = 2m;
        public const int RecordIdIs0 = 0;


        #endregion

        #region Properties

        IServiceFactory ServiceFactory { get; }

        #endregion

        #region Public Methods

        public IBill CreateBill()
        {
            IBill bill = new Bill();
            bill.DateOwed = new DateTime(2017, 05, 23);
            bill.MonthlyPayment = 5.67m;
            return bill;
        }

        #endregion

        #region Helper Methods


        protected void CreateAccountData()
        {
            IAccountService service = MockAccountService.Singleton;
            IAccount account = new Account();
            account.CompanyName = "Haribo";
            account.AccountBalance = 200.00m;
            account.InterestRate = 3.9m;
            account.GeneratePaymentSchedule(DateTime.Now, 20.00m);
            service.AddAccount(account);
        }

        protected void CreatePayDayData()
        {
            IPayDayService service = MockPayDayService.Singleton;
            IPayDay payDay = new PayDay();
            payDay.Date = new DateTime(2017, 05, 05);
            payDay.Amount = 1000.21m;
            service.AddPayDay(payDay);
        }

        #endregion

    }
}
