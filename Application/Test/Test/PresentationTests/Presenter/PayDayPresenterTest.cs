using Domain;
using NUnit.Framework;
using Presentation;
using Presentation.Presenter;
using System;
using Test.Mock;

namespace Test.PresentationTests.Presenter
{
    [TestFixture]
    public class PayDayPresenterTest : AbstractTest
    {

        private PayDayPresenter Presenter;
        private PayDayModel Model;
        private IPayDayService Service;

        [SetUp]
        public void SetUp()
        {
            Presenter = new PayDayPresenter();
            Service = MockPayDayService.Singleton;
        }

        #region Blue Sky Tests

        [Test]
        public void TestBlueSky_AddPayDay()
        {
            //set-up
            Model = CreatePayDayModel();
            IPayDay payDayShouldNotBeInDb = Service.GetPayDay(Model.RecordId);

            //Pre-condition
            Assert.IsNull(payDayShouldNotBeInDb);

            //exercise
            Presenter.SavePayDay(Model);
            IPayDay payDayShouldBeInDb = Service.GetPayDay(1);

            //post-condition
            Assert.IsNotNull(payDayShouldBeInDb);
        }

        [Test]
        public void TestBlueSky_GetPayDay()
        {
            //set-up
            Model = CreatePayDayModel();
            Presenter.SavePayDay(Model);
            Model = null;

            //pre-condition
            Assert.IsNull(Model);

            //exercise
            Model = Presenter.GetPayDay(1);

            //post-condition
            Assert.IsNotNull(Model);
        }

        [Test]
        public void TestBlueSky_GetPayDaysInMonth()
        {
            //set-up
            Model = CreatePayDayModel();
            Presenter.SavePayDay(Model);
            PayDayModel[] models = null;

            //pre-condition
            Assert.IsNull(models);

            //exercise
            models = Presenter.GetPayDaysInMonth(new DateTime(2017, 05, 05));

            //post-condition
            Assert.IsNotNull(models);
        }

        [Test]
        public void TestBlueSky_UpdatePayDay()
        {
            //set-up
            Model = CreatePayDayModel();
            Presenter.SavePayDay(Model);
            PayDayModel newModel = Presenter.GetPayDay(1);
            newModel.Date = Model.Date.AddDays(1);
            newModel.Amount = Model.Amount + 1m;

            //pre-condition
            Assert.AreNotEqual(Model.Date, newModel.Date);
            Assert.AreNotEqual(Model.Amount, newModel.Amount);

            //exercise
            Presenter.UpdatePayDay(newModel);
            Model = Presenter.GetPayDay(newModel.RecordId);

            //post-condition
            Assert.AreEqual(Model.Date, newModel.Date);
            Assert.AreEqual(Model.Amount, newModel.Amount);
        }
        #endregion



        [TearDown]
        public void TearDown()
        {
        }

        #region Helper Methods

        private PayDayModel CreatePayDayModel()
        {
            PayDayModel model = new PayDayModel();
            model.Date = new DateTime(2017, 05, 05);
            model.Amount = 1000m;
            model.RecordId = 0;
            return model;
        }


        #endregion

    }
}
