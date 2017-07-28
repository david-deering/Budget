using Domain;
using NUnit.Framework;
using Presentation;
using System;
using Test.Mock;

namespace Test.PresentationTests.Presenter
{
    [TestFixture]
    public class AccountPresenterTest : AbstractTest
    {

        private AccountPresenter Presenter;
        private AccountModel AccountModel;
        private AddAccountModel AddAccountModel;

        [SetUp]
        public void SetUp()
        {
            Presenter = new AccountPresenter();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_EditAccount()
        {
            //set-up
            IAccountService service = MockAccountService.Singleton;
            CreateAccountData();
            AccountModel = new AccountModel();
            AccountModel.RecordId = 1;
            AccountModel.AccountBalance = 100m;
            AccountModel.CompanyName = "test";
            AccountModel.InterestRate = 2m;

            IAccount account = service.GetAccount(1);

            //pre-conditions
            Assert.AreNotEqual(account.AccountBalance, AccountModel.AccountBalance);
            Assert.AreNotEqual(account.CompanyName, AccountModel.CompanyName);
            Assert.AreNotEqual(account.InterestRate, AccountModel.InterestRate);
            Assert.AreEqual(account.RecordId, AccountModel.RecordId);

            //exercise
            Presenter.EditAccount(AccountModel);

            //post-conditions
            Assert.AreEqual(account.AccountBalance, AccountModel.AccountBalance);
            Assert.AreEqual(account.CompanyName, AccountModel.CompanyName);
            Assert.AreEqual(account.InterestRate, AccountModel.InterestRate);
            Assert.AreEqual(account.RecordId, AccountModel.RecordId);
        }

        [Test]
        public void TestBlueSky_SaveAccount()
        {
            //set-up
            IAccountService service = MockAccountService.Singleton;
            AddAccountModel = new AddAccountModel();
            AddAccountModel.AccountBalance = 100m;
            AddAccountModel.CompanyName = "test";
            AddAccountModel.InterestRate = 2m;
            AddAccountModel.FirstDueDate = new DateTime(2017, 05, 05);
            AddAccountModel.AmountDue = 10m;

            //exercise
            Presenter.SaveAccount(AddAccountModel);

            //post-conditions
            IAccount account = service.GetAccount(1);
            Assert.AreEqual(account.AccountBalance, AddAccountModel.AccountBalance);
            Assert.AreEqual(account.CompanyName, AddAccountModel.CompanyName);
            Assert.AreEqual(account.InterestRate, AddAccountModel.InterestRate);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_()
        {

        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }

        #region Helper Methods



        #endregion

    }
}
