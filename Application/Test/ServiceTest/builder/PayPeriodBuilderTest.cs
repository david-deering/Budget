using Domain;
using NUnit.Framework;
using Service;
using System;
using Test.Mock;

namespace Dmi.ServiceTest.builder
{
    [TestFixture]
    public class PayPeriodBuilderTest
    {

        private PayPeriodBuilder FirstPayPeriodBuilder;

        private IPayDay FirstPayDay;
        private IPayDay SecondPayDay;

        private IAccountService AccountService;
        private IServiceFactory Factory;

        [SetUp]
        public void SetUp()
        {
            ServiceFactoryProxy.Singleton.SetServiceFactory(new MockServiceFactory());
            Factory = ServiceFactoryProxy.Singleton.ServiceFactory;
            AccountService = Factory.CreateAccountService();

        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Build_NoDeficits()
        {
            //set-up
            CreateAccounts();
            FirstPayDay = CreatePayDay(new DateTime(2017, 05, 01), 10);
            SecondPayDay = CreatePayDay(new DateTime(2017, 05, 05), 10);
            FirstPayPeriodBuilder = new PayPeriodBuilder(FirstPayDay, SecondPayDay.Date);

            //exercise
            FirstPayPeriodBuilder.Build();

            //post-conditions
            Assert.AreEqual(5, FirstPayPeriodBuilder.Surplus);
        }

        [Test]
        public void TestBlueSky_Build_Deficit()
        {
            //set-up
            CreateAccounts();
            FirstPayDay = CreatePayDay(new DateTime(2017, 05, 01), 0);
            SecondPayDay = CreatePayDay(new DateTime(2017, 05, 05), 10);
            FirstPayPeriodBuilder = new PayPeriodBuilder(FirstPayDay, SecondPayDay.Date);

            //exercise
            FirstPayPeriodBuilder.Build();

            //post-conditions
            Assert.AreEqual(5, FirstPayPeriodBuilder.Deficit);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            MockAccountService service = AccountService as MockAccountService;
            service.ClearMockService();
        }

        #region Helper Methods

        private void CreateAccounts()
        {
            IAccount account = new Account();

            account = new Account();
            account.RecordId = 0;
            account.AccountBalance = 10000m;
            account.CompanyName = "Test Company 1";
            account.InterestRate = 0;
            IBill bill = new Bill();
            bill.RecordId = 1;
            bill.DateOwed = new DateTime(2017, 04, 30);
            bill.Paid = true;
            bill.ConfirmationNumber = "A";
            bill.MonthlyPayment = 5m;
            account.AddBill(bill);
            bill = new Bill();
            bill.RecordId = 2;
            bill.DateOwed = new DateTime(2017, 05, 03);
            bill.Paid = false;
            bill.ConfirmationNumber = "";
            bill.MonthlyPayment = 5m;
            account.AddBill(bill);
            AccountService.AddAccount(account);

            account = new Account();
            account.RecordId = 0;
            account.AccountBalance = 10000m;
            account.CompanyName = "Test Company 2";
            account.InterestRate = 0;
            bill = new Bill();
            bill.RecordId = 3;
            bill.DateOwed = new DateTime(2017, 04, 02);
            bill.Paid = false;
            bill.ConfirmationNumber = "A";
            bill.MonthlyPayment = 5m;
            account.AddBill(bill);
            bill = new Bill();
            bill.RecordId = 4;
            bill.DateOwed = new DateTime(2017, 05, 23);
            bill.Paid = false;
            bill.ConfirmationNumber = "";
            bill.MonthlyPayment = 5m;
            account.AddBill(bill);
            AccountService.AddAccount(account);
        }

        private IPayDay CreatePayDay(DateTime date, decimal amount)
        {
            IPayDay payDay = new PayDay();
            payDay.Amount = amount;
            payDay.Date = date;
            payDay.RecordId = 0;
            return payDay;
        }


        #endregion

    }
}
