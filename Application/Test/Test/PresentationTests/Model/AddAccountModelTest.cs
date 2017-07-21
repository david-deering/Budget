using NUnit.Framework;
using Presentation;
using System;

namespace Test.PresentationTests.model
{
    [TestFixture]
    public class AddAccountModelTest
    {

        private AddAccountModel Model;

        [SetUp]
        public void SetUp()
        {
            Model = new AddAccountModel();
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_Coverage()
        {
            //Exercise
            Model.CompanyName = "Test";
            Model.AccountBalance = 10m;
            Model.AmountDue = 2m;
            Model.FirstDueDate = new DateTime(2017, 05, 05);
            Model.InterestRate = 2m;

            //post-conditions
            Assert.AreEqual("Test", Model.CompanyName);
            Assert.AreEqual(10m, Model.AccountBalance);
            Assert.AreEqual(2m, Model.AmountDue);
            Assert.AreEqual(new DateTime(2017, 05, 05), Model.FirstDueDate);
            Assert.AreEqual(2m, Model.InterestRate);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }

    }
}
