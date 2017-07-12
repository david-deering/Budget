using System.Windows.Forms;
using Domain;
using NUnit.Framework;
using Presentation;
using Test.Mock;

namespace Test.PresentationTests
{
    [TestFixture]
    public class MainWindowPresenterTest
    {

        private MainWindowPresenter Presenter;

        [SetUp]
        public void SetUp()
        {
            ServiceFactoryProxy.Singleton.SetServiceFactory(new MockServiceFactory());
            Presenter = new MainWindowPresenter();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_CreateHeaders()
        {
            //set-up
            string[] headers = new string[0];

            //pre-conditions
            Assert.AreEqual(0, headers.Length);

            //exercise
            headers = Presenter.GetHeaderValues();

            //post-conditions
            Assert.AreEqual("Company Name", headers[0]);
            Assert.AreEqual("Monthly Payment", headers[1]);
            Assert.AreEqual("Date Due", headers[2]);
            Assert.AreEqual("Full Amount", headers[3]);
        }


        [Test]
        public void TestBlueSky_CreateRows()
        {
            //set-up
            Presenter.MakeDatabaseEntries();
            ListViewItem[] rows = new ListViewItem[0];

            //pre-conditions
            Assert.AreEqual(0, rows.Length);

            //exercise
            rows = Presenter.CreateRows();

            //post-conditions
            Assert.AreEqual(1, rows.Length);
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
