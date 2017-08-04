using Domain;
using NUnit.Framework;
using System;
using System.Linq;

namespace Dmi.ServiceTest.service
{
    [TestFixture]
    public class AccountServiceTest : AbstractServiceTest
    {

        private IAccountService AccountService;

        [SetUp]
        public void SetUp()
        {
            AccountService = ServiceFactory.CreateAccountService();
        }


        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_AddAccount()
        {
            // set-up
            IAccount account = CreateAccount();

            // pre-conditions
            Assert.IsNull(AccountService.GetAccount(account.RecordId));

            // exercise
            AccountService.AddAccount(account);
            IAccount persistedAccount = AccountService.GetAccount(account.RecordId);

            // post-conditions
            Assert.AreEqual(persistedAccount, account);
        }

        [Test]
        public void TestBlueSky_DeleteAccount()
        {
            // set-up
            IAccount account = CreateAccount();

            AccountService.AddAccount(account);

            // pre-conditions
            Assert.AreEqual(1, AccountService.GetAccounts().Length);

            // exercise
            AccountService.DeleteAccount(account.RecordId);

            // post-conditions
            Assert.AreEqual(0, AccountService.GetAccounts().Length);
        }

        [Test]
        public void TestBlueSky_GetAccount()
        {
            // set-up
            IAccount account = CreateAccount();

            AccountService.AddAccount(account);

            // exercise
            IAccount persistedAccount = AccountService.GetAccount(account.RecordId);

            // post-conditions
            Assert.AreEqual(persistedAccount, account);
        }


        [Test]
        public void TestBlueSky_GetBills()
        {
            // set-up
            IAccount account = CreateAccount();
            AccountService.AddAccount(account);

            // exercise
            IBill[] bills = AccountService.GetBills(account.RecordId);

            // post-conditions
            Assert.AreEqual(1, bills.Length);
        }


        [Test]
        public void TestBlueSky_GetBill()
        {
            // set-up
            IAccount account = CreateAccount();
            AccountService.AddAccount(account);
            IBill someBill = AccountService.GetBills(account.RecordId)[0];
            int billRecordId = someBill.RecordId;

            // exercise
            IBill bill = AccountService.GetBill(billRecordId);

            // post-conditions
            Assert.AreEqual(bill, someBill);
        }

        [Test]
        public void TestBlueSky_UpdateAccount()
        {
            // set-up
            IAccount account = CreateAccount();

            AccountService.AddAccount(account);

            IAccount persistedAccount = AccountService.GetAccount(account.RecordId);

            // exercise
            //            persistedAccount.Period.EffectiveStartDate = new DateTime(2017, 04, 17);
            AccountService.UpdateAccount(persistedAccount);

            // post-conditions
            Assert.AreEqual(persistedAccount, account);
        }

        #endregion

        #region Non Blue Sky Tests

        [Test]
        public void TestNonBlueSky_AddInvalidAccount()
        {
            // set-up
            IAccount account = null;

            // pre-conditions
            Assert.AreEqual(0, AccountService.GetAccounts().Length);

            // exercise
            AccountService.AddAccount(account);

            // post-conditions
            Assert.AreEqual(0, AccountService.GetAccounts().Length);
        }

        [Test]
        public void TestNonBlueSky_DeleteAccountNotFound()
        {
            // set-up
            IAccount account = CreateAccount();
            AccountService.AddAccount(account);

            // pre-conditions
            Assert.AreEqual(1, AccountService.GetAccounts().Length);

            // exercise
            AccountService.DeleteAccount(0);

            // post-conditions
            Assert.AreEqual(1, AccountService.GetAccounts().Length);
        }

        [Test]
        public void TestNonBlueSky_UpdateWithInvalidAccount()
        {
            // set-up
            IAccount account = CreateAccount();

            AccountService.AddAccount(account);

            IAccount persistedAccount = AccountService.GetAccount(account.RecordId);

            // exercise
            persistedAccount = null;
            AccountService.UpdateAccount(persistedAccount);

            // post-conditions
            Assert.AreNotEqual(persistedAccount, account);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            DeleteAllAccounts();
        }

        #region Helper Methods

        private IAccount CreateAccount()
        {
            IAccount account = new Account();
            account.CompanyName = "Haribo";
            account.AccountBalance = 200.00m;
            account.InterestRate = 3.9m;
            account.GeneratePaymentSchedule(DateTime.Now, 20.00m);
            return account;
        }

        private void DeleteAllAccounts()
        {
            IAccount[] accounts = AccountService.GetAccounts();

            accounts.ToList().ForEach(DeleteAccount);
        }

        private void DeleteAccount(IAccount account)
        {
            AccountService.DeleteAccount(account.RecordId);
        }
    }
    #endregion
}