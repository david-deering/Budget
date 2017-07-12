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
            Assert.AreNotEqual(bill.Name, model.Name);
            Assert.AreNotEqual(bill.DateOwed, model.DateOwed);
            Assert.AreNotEqual(bill.MonthlyPayment, model.MonthlyPayment);
            Assert.AreNotEqual(bill.TotalOwed, model.TotalOwed);

            //exercise
            model.CopyFrom(bill);

            Assert.AreEqual(bill.Name, model.Name);
            Assert.AreEqual(bill.DateOwed, model.DateOwed);
            Assert.AreEqual(bill.MonthlyPayment, model.MonthlyPayment);
            Assert.AreEqual(bill.TotalOwed, model.TotalOwed);

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
