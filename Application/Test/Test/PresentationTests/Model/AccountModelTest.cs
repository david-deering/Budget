using Domain;
using NUnit.Framework;
using Presentation;

namespace Test.PresentationTests.Model
{
    [TestFixture]
    public class AccountModelTest : AbstractTest
    {

        private AccountModel Model;

        [SetUp]
        public void SetUp()
        {
            Model = new AccountModel();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_CopyFrom()
        {
            //set-up
            IBill bill1 = CreateBill();
            IBill bill2 = CreateBill();

            IAccount account = new Account();
            account.CompanyName = CompanyName;
            account.AccountBalance = AccountBalance;
            account.InterestRate = InterestRate;
            account.RecordId = RecordIdIs0;
            account.AddBill(bill1);
            account.AddBill(bill2);

            //pre-conditions
            Assert.IsNull(Model.Bills);
            Assert.AreNotEqual(Model.AccountBalance, account.AccountBalance);
            Assert.AreNotEqual(Model.CompanyName, account.CompanyName);
            Assert.AreNotEqual(Model.InterestRate, account.InterestRate);

            //exercise
            Model.CopyFrom(account);

            //post-conditions
            Assert.AreEqual(Model.Bills.Length, account.GetBills().Length);
            Assert.AreEqual(Model.AccountBalance, account.AccountBalance);
            Assert.AreEqual(Model.CompanyName, account.CompanyName);
            Assert.AreEqual(Model.InterestRate, account.InterestRate);

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
