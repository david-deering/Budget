using Domain;
using NUnit.Framework;
using Presentation;

namespace Test.PresentationTests.model
{
    [TestFixture]
    public class BillModelTest : AbstractTest
    {

        private BillModel BillModel;

        [SetUp]
        public void SetUp()
        {
            BillModel = new BillModel();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_CopyFrom()
        {
            //set-up
            IBill bill = CreateBill();
            BillModel model = new BillModel();

            //pre-conditions
            Assert.AreNotEqual(bill.DateOwed, model.DateOwed);
            Assert.AreNotEqual(bill.MonthlyPayment, model.MonthlyPayment);

            //exercise
            model.CopyFrom(bill);

            Assert.AreEqual(bill.DateOwed, model.DateOwed);
            Assert.AreEqual(bill.MonthlyPayment, model.MonthlyPayment);

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
