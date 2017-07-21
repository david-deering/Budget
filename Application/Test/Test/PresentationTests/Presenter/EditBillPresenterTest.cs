using Domain;
using NUnit.Framework;
using Presentation;
using Test.Mock;

namespace Test.PresentationTests
{
    [TestFixture]
    public class EditBillPresenterTest : AbstractTest
    {

        private EditBillPresenter EditBillPresenter;
        private IBill Bill;

        [SetUp]
        public void SetUp()
        {
            ServiceFactoryProxy.Singleton.SetServiceFactory(new MockServiceFactory());
            EditBillPresenter = new EditBillPresenter();
            Bill = CreateBill();

        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_EditBill()
        {
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
